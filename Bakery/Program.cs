using System;
using Bakery.Models;
namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.WriteLine("Welcome To Bakery de Pierre");
      Console.WriteLine("Bread is $5 each. Buy 2 Get 3rd free.");
      Console.WriteLine("Pastries are $2 each. Buy 2 Get 3rd for $1.");
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("Would you like to purchase: type Bread or Pastry");
      string userChoice = Console.ReadLine().ToLower();

      if (userChoice == "bread")
      {
        Console.WriteLine("How many loaves of bread would you like?");
        string breadAmount = Console.ReadLine();
        int parsBreadAmount = int.Parse(breadAmount);
        Bread newBread = new Bread(parsBreadAmount);
        int breadPrice = newBread.SetPrice();
        Console.WriteLine("Will that complete your order or would you like to purchase another good?(type complete/another)");
        string orderConfirm = Console.ReadLine().ToLower();
        if (orderConfirm == "complete")
        {
          Console.WriteLine("For " + parsBreadAmount + ", your total comes to $" + breadPrice + ".");
          Console.WriteLine("Thank you for your business <3");
        } else if (orderConfirm == "another")
        {
          Console.WriteLine("How many pastries?");
          string pastryAmount = Console.ReadLine();
          int parsPastryAmount = int.Parse(pastryAmount);
          Pastry newPastry = new Pastry(parsPastryAmount);
          int pastryPrice = newPastry.SetPrice();
          int totalPrice = OrderTotal.CalculatedTotal(pastryPrice, breadPrice);
          Console.WriteLine("Amount of Pastries = " + parsPastryAmount + ", cost = $" + pastryPrice + ".");
          Console.WriteLine("Amount of Bread = " + parsBreadAmount + ", cost = $" + breadPrice + ".");
          Console.WriteLine("Your total comes to $" + totalPrice + ".");
          Console.WriteLine("Thank you for your business <3");
        }
      } else if (userChoice == "pastry" || userChoice == "pastries")
      {
        Console.WriteLine("How many pastries would you like?");
        string pastryAmount = Console.ReadLine();
        int parsPastryAmount = int.Parse(pastryAmount);
        Pastry newPastry = new Pastry(parsPastryAmount);
        int pastryPrice = newPastry.SetPrice();
        Console.WriteLine("For " + parsPastryAmount + ", your total comes to $" + pastryPrice + ".");
      }
    }
  }
}