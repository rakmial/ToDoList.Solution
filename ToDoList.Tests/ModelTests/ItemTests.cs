using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;
using System.Collections.Generic;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      string result = newItem.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Pet the cat.";
      Item newItem = new Item(description);

      string updatedDescription = "Cat pets you.";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]    
    public void Remove_RemoveItemFromList_ItemList()
    {
      string firstDescription = "Wash the dog";
      string secondDescription = "Buy frisbee";
      Item firstItem = new Item(firstDescription);
      Item secondItem = new Item(secondDescription);
      List<Item> compareList = new List<Item> {secondItem};

      Item.Remove(1);

      CollectionAssert.AreEqual(compareList, Item.GetAll());
      
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> newList = new List<Item> {};
      List<Item> result = Item.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsItemList_ItemList()
    {
      string firstDescription = "Tart and bright.";
      string secondDescription = "Hoppy, yet mellow";
      Item firstItem = new Item(firstDescription);
      Item secondItem = new Item(secondDescription);
      List<Item> newList = new List<Item> {firstItem,secondItem};

      CollectionAssert.AreEqual(newList, Item.GetAll());
    }
  }
}