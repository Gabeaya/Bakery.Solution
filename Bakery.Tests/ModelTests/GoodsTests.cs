using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class GoodsTests
  {

    [TestMethod]
    
    public void BreadConstructor_CreatesAnInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void SetAmount_SetAmountOfBread_Int()
    {
      int breadCount = 1;
      Bread newBread = new Bread(breadCount);
      Assert.AreEqual(1, newBread.Amount);
    }

    [TestMethod]
    public void SetPrice_SetPriceGivenTheAmountOfBread_Int()
    {
      int breadCount = 1;
      Bread newBread = new Bread(breadCount);
      newBread.SetPrice();
      Assert.AreEqual(5, newBread.SetPrice());
    }

    [TestMethod]
    public void SetPrice_SetPriceGivenTheDiscount_Int()
    {
      int breadCount = 3;
      Bread newBread = new Bread(breadCount);
      newBread.SetPrice();
      Assert.AreEqual(10, newBread.SetPrice());
    }
    [TestMethod]
    public void SetPrice_SetPriceWithAmountGreaterThanThree_Int()
    {
      int breadCount = 16;
      Bread newBread = new Bread(breadCount);
      newBread.SetPrice();
      Assert.AreEqual(55, newBread.SetPrice());
    }

    [TestMethod]
    
    public void PastryConstructor_CreatesAnInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void SetAmount_SetAmountOfPastry_Int()
    {
      int pastryCount = 1;
      Pastry newPastry = new Pastry(pastryCount);
      Assert.AreEqual(1, newPastry.Amount);
    }

    [TestMethod]
    public void SetPrice_SetPriceGivenTheAmountOfPastry_Int()
    {
      int pastryCount = 1;
      Pastry newPastry = new Pastry(pastryCount);
      newPastry.SetPrice();
      Assert.AreEqual(2, newPastry.SetPrice());
    }

  }
}