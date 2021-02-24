//add list of items to be completed
//see a list of the tasks they have already added
//prompt user:  Add to list or check list (Add/Check)
using System;
using System.Collections.Generic;
using ToDoList.Models;


namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the program what would you like to do today? Add or View");
      string response = Console.ReadLine();
      bool flag = false;
      if(flag == false) {
          Item newItem = new Item();
          flag = true;
      }
      if(response == "Add")
      {
        Console.WriteLine("What would you like to add?");
        string answer = Console.ReadLine();
        Item.AddToList(answer);
      }
      else if(response == "View")
      {
        List<string> listItems = Item.GetAll();
        foreach (string element in listItems) {
          Console.WriteLine(element);
        }
      }
      else {
        Console.WriteLine("You choose wrong option - nothing to display");
      }
      Main();
    }
  }
}