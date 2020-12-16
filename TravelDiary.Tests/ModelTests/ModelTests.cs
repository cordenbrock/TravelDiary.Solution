using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravelDiary.Models;

namespace TravelDiary.Tests
{
  [TestClass]
  public class PlacesTest
  {
    [TestMethod]
    public void PlaceConstructor_MakesNewPlaceObject_Place()
    {
      Place newPlace = new Place("Iceland");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
  }
}