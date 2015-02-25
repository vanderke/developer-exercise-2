using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SixPillars.Web.Views;
using SixPillars.Web.Interfaces;
namespace SixPillarsUnitTests
{
    [TestClass]
    public class SixPillarsViewTests
    {
        [TestMethod]
        public void EmptyPillarsTest()
        {
            ISixPillarsModel myModel = new Mocks.MockSixPillarsModel();
            SixPillarsView myView = new SixPillarsView(myModel);
            Assert.AreEqual(0, myView.Pillars.Count);
        }
        [TestMethod]
        public void OnePillarTest()
        {
            ISixPillarsModel myModel = new Mocks.MockSixPillarsModel();
            SixPillarsView myView = new SixPillarsView(myModel);
            myView.Pillars.Add(new SixPillars.Web.Pillar() { Title = "pillar uno", Description = "my description", Scripture = "John 3:16" });
            Assert.AreEqual(1, myView.Pillars.Count);
        }
    }
}
