namespace Bakery.Models
{
  public class Bread
  {
    //Properties
    public int Amount { get; set; }
    public int Price { get; set; }

    //constructor
    public Bread(int amount, int price = 0)
    {
      Amount = amount;
      Price = price;
    }
    public int SetPrice()
    {
      if (Amount >2)
      {
        Price = ((Amount / 3) * 10);
        return Price;
      }
      Price = Amount * 5;
      return Price;
    }
    
  }
}