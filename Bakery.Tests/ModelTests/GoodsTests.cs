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
  }
}