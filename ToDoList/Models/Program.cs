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
      string listEmpty = "You currently have nothing on your list.";
      string prompt = "What would you like to do? [add / remove / exit]";
      string descriptionQuery = "Type what you want to put on your list.";
      string response;
      List<Item> emptyList = new List<Item> {};
      Console.WriteLine("Welcome to this CLI To-Do List.");
      while (!exitProgram)
      {
        if (Item.GetAll() == emptyList)
        {
          Console.WriteLine(listEmpty);
        }
        else
        {
          Console.WriteLine(Item.GetAll());
        }
        Console.WriteLine(prompt);
        response = Console.ReadLine();
        if  (response == "add")
        {
          Console.WriteLine(descriptionQuery);

        }
      }
    }
  }
}