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
      Console.WriteLine("Would you like to purchase: Bread or Pastries");
      string userChoice = Console.ReadLine().ToLower();

      if (userChoice == "bread")
      {
        Console.WriteLine("How many loafs of bread?");
        string breadAmount = Console.ReadLine();
        int parsedBreadAmount = int.Parse(breadAmount);

        
        Bread newBread = new Bread(parsedBreadAmount);
        int breadPrice = newBread.SetPrice();

        Console.WriteLine("For " + parsedBreadAmount + " loaves your total comes to $" + breadPrice + ".");
      }
    }
  }
}