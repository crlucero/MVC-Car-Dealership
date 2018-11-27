using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
    public class HomeController : Controller
    {

        [Route("/index")]
        public ActionResult Index()
        {
            return View();
        }

       [Route("/vehicles/new")]
        public ActionResult Form() 
        { 
            return View(); 
        }

        [Route("/vehicles")]
        public ActionResult Vehicles(string make, string model, int year, int miles, string message, int price)
        {
            List<Car> allCars = Car.GetAll();
            Car myCarVariable = new Car();
            myCarVariable.SetMake(make);
            myCarVariable.SetModel(model);
            myCarVariable.SetYear(year);
            myCarVariable.SetMiles(miles);
            myCarVariable.SetMessage(message);
            myCarVariable.SetPrice(price);
            return View(allCars);
        }
    }
}