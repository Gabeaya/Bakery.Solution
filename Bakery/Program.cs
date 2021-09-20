using System;
using Bakery.Models;
namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome To Bakery de Pierre");
      Console.WriteLine("Bread is $5 each. Buy 2 Get 3rd free.");
      Console.WriteLine("Pastries are $2 each. Buy 2 Get 3rd for $1.");
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("Would you like to purchase: type Bread or Pastry");
      string userChoice = Console.ReadLine().ToLower();

      if (userChoice == "bread")
      {
        Console.WriteLine("How many loaves of bread?");
        string breadAmount = Console.ReadLine();
        int parsBreadAmount = int.Parse(breadAmount);
        if (parsBreadAmount < 2)
        {
          Bread newBread = new Bread(parsBreadAmount);
        int breadPrice = newBread.SetPrice();
        Console.WriteLine("For " + parsBreadAmount + " loaf your total comes to $" + breadPrice + ".");
        } else 
        {
          Bread newBread = new Bread(parsBreadAmount);
        int breadPrice = newBread.SetPrice();
        Console.WriteLine("For " + parsBreadAmount + " loaves your total comes to $" + breadPrice + ".");
        }
      } else if (userChoice == "pastry" || userChoice == "pastries")
      {
        Console.WriteLine("How many pastries?");
        string pastryAmount = Console.ReadLine();
        int parsPastryAmount = int.Parse(pastryAmount);
        if (parsPastryAmount < 2)
        {
          Pastry newPastry = new Pastry(parsPastryAmount);
          int pastryPrice = newPastry.SetPrice();
          Console.WriteLine("For " + parsPastryAmount + " pastry your total comes to $" + pastryPrice + ".");
        } else 
        {
          Pastry newPastry = new Pastry(parsPastryAmount);
          int pastryPrice = newPastry.SetPrice();
          Console.WriteLine("For " + parsPastryAmount + " pastries your total comes to $" + pastryPrice + ".");
        }
        

      }
    }
  }
}