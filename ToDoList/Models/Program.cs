using ToDoList.Models;
using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Program
  {
    public static void Main()
    {
      bool exitProgram = false;
      int listCount = 0;
      string response;
      string listEmpty = "You currently have nothing on your list.";
      string prompt = "What would you like to do? [add / remove / exit]";
      string descriptionQuery = "Type what you want to put on your list.";
      string removeQuery = $"Enter number between 1 and {listCount} to remove that item.";
      List<Item> emptyList = new List<Item> {};
      List<Item> currentList;
      Console.WriteLine("Welcome to this CLI To-Do List.");
      while (!exitProgram)
      {
        if (Item.GetAll() == emptyList)
        {
          Console.WriteLine(listEmpty);
        }
        else
        {
          Console.WriteLine(Item.GetPretty());
        }
        Console.WriteLine(prompt);
        response = Console.ReadLine();
        if  (response == "add")
        {
          Console.WriteLine(descriptionQuery);
          Item newItem = new Item(Console.ReadLine());
        }
        else if (response == "remove")
        {
          currentList = Item.GetAll();
          listCount = currentList.Count;
          Console.WriteLine(removeQuery);
          Item.Remove(int.Parse(Console.ReadLine()));
        }
        else if (response == "exit")
        {
          exitProgram = true;
        }
      }
    }
  }
}