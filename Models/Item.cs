using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    // We add set; to the line below.
    public string Description { get; set; }
    private static List<string> _instances = new List<string> {};

    public Item()
    {
      // Description = description;
      // _instances.Add(this); // New code.
    }

    public static List<string> GetAll()
    {
      return _instances;
    }

    public static void AddToList(string toDo)
    {
       _instances.Add(toDo); // New code.
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}

