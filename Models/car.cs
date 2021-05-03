using System;

namespace Dealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }
    public int GetPrice()
    {
      return _price;
    }
    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }
  }
}
// public class Program
// {
// public static void Main()
// {
//   Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
//   Car yugo = new Car("1980 Yugo Koral", 700, 56000);
//   Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
//   Car amc = new Car("1976 AMC Pacer", 400, 198000);

//   List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

//   Console.WriteLine("Enter maximum price: ");
//   string stringMaxPrice = Console.ReadLine();
//   int maxPrice = int.Parse(stringMaxPrice);

//   List<Car> CarsMatchingSearch = new List<Car>(0);
//   foreach (Car automobile in Cars)
//   {
//     if (automobile.WorthBuying(maxPrice))
//     {
//       CarsMatchingSearch.Add(automobile);
//     }
//   }
//   foreach (Car automobile in CarsMatchingSearch)
//   {
//     Console.WriteLine(automobile.MakeModel);
//   }
// }
// }
