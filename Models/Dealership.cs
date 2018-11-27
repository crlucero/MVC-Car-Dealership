using System.Collections.Generic;

namespace Dealership.Models 
{

 public class Car
  {
    private string _make;
    private string _model;
    private int _price;
    private int _miles;
    private string _message;
    private int _year;
    private static List<Car> _instances = new List<Car> {};

    public Car()
    {
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public int GetYear()
    {
      return _year;
    }
    
    public void SetYear(int newYear)
    {
      _year = newYear;
    }

    public string GetMake()
    {
      return _make;
    }
    
    public void SetMake(string newMake)
    {
      _make = newMake;
    }

    public string GetModel()
    {
      return _model;
    }

    public void SetModel(string newModel)
    {
      _model = newModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }

    public string GetMessage()
    {
      return _message;
    }

    public void SetMessage(string newMessage)
    {
      _message = newMessage;
    }

  }

}