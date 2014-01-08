using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HowFar.Specs
{
    [TestClass]
    public class UnitTest1
    {
        Maybe<Location> unknown = new Nothing<Location>();
        Maybe<Location> known = new Just<Location>(new Location(50.8938408, 3.8179326));

        [TestMethod]
        public void CalculatingDistances()
        {
            Assert.IsTrue(DistanceCalculator.Distance(unknown, known).IsNothing);
            Assert.IsTrue(DistanceCalculator.Distance(known, unknown).IsNothing);
            Assert.IsTrue(DistanceCalculator.Distance(unknown, unknown).IsNothing);
            Assert.IsFalse(DistanceCalculator.Distance(known, known).IsNothing);
        }
    }
}
