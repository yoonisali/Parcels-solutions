using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcelSolution.Models;

namespace ParcelSolution.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelsConstructor_CreatesInstanceOfParcel_Parcel()
    {
      Parcels oldParcel = new Parcels(3, 3, 3, 3);
      Assert.AreEqual(typeof(Parcels), oldParcel.GetType());
    }
    [TestMethod]
    public void CostToShip_ReturnsTotalCost_TotalCost()
    {
      int Volume = 2;
      int Weight = 2;
      Parcels newParcel = new Parcels(Volume, Weight, 1, 1);
      string result = newParcel.CostToShip();
      Assert.AreEqual(result, "100");
    }
  }
}

  