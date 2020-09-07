using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    
    private static List<Item> _instances = new List<Item> {};

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }
    public static void Remove(int i)
    {
      //if (_instances[i-1])
      //{
      _instances.RemoveAt(i-1);
      //}
      //else
      //{
      //  return;
      //}
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
    
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static string GetPretty()
    {
      string rv = "";
      int listNumber = 1;
      for (int i = 0; i < _instances.Count; i++)
      {
        rv = rv + $"{listNumber}. {_instances[i].Description}\n";
        listNumber++;
      }
      return rv;
    }
  }
}