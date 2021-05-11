using Microsoft.AspNetCore.Mvc;
using CarsList.Models;
using System.Collections.Generic;

namespace CarsList.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string description, string make, int year, float price)
    {
      Car myCar = new Car(description, make, year, price);
      return RedirectToAction("Index");
    }

  }
}