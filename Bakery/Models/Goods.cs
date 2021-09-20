namespace Bakery.Models
{
  public class Bread
  {
    //Properties
    public int BreadAmount { get; set; }
    public int BreadPrice { get; set; }

    //constructor
    public Bread(int amount, int price = 0)
    {
      BreadAmount = amount;
      BreadPrice = price;
    }
    public int SetPrice()
    {
      if (BreadAmount >2)
      {
        BreadPrice = ((BreadAmount / 3) * 10)+((BreadAmount % 3)*5);
        return BreadPrice;
      }
      BreadPrice = BreadAmount * 5;
      return BreadPrice;
    }
  }

  public class Pastry
  {
    public int PastryAmount { get; set; }
    public int PastryPrice { get; set; }

    public Pastry (int amount, int price=0)
    {
      PastryAmount = amount;
      PastryPrice = price;
    }
    public int SetPrice()
    {
      if(PastryAmount >2)
      {
        PastryPrice = ((PastryAmount / 3) * 5) + ((PastryAmount % 3)*2);
        return PastryPrice;
      }
      PastryPrice = PastryAmount * 2;
      return PastryPrice;
    }
  }
  public class OrderTotal
  {
    public static int CalculatedTotal(int BreadPrice, int PastryPrice)
    {
      int Total =  PastryPrice + BreadPrice;
      return Total;
    }
  }


}