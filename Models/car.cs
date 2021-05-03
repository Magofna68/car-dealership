using System;

namespace Dealership.Models
{
  public class Car
  {
    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }


  // -------------- NOTES -----------------


  // public string GetMakeModel()
  // {
  //   return MakeModel;
  // }
  // // -------------------- Property below: -------------------
  //     public string MakeModel
  //     {
  //       get
  //       {
  //         return _makeModel;
  //       }
  //       set
  //       {
  //         _makeModel = value;
  //       }
  //     }
  // --------------------------------------------------------
  // public int GetPrice()
  // {
  //   return _price;
  // }
  // public int GetMiles()
  // {
  //   return _miles;
  // }

  // public void SetPrice(int newPrice)
  // {
  //   _price = newPrice;
  // }

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
