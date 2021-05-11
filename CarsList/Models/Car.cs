using System.Collections.Generic;

namespace CarsList.Models
{
  public class Car
  {
    public string Description { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }
    public float Price { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string description, string make, int year, float price)
    {
      Description = description;
      Make = make;
      Year = year;
      Price = price;

      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}