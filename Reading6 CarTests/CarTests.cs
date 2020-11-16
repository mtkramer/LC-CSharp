using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise6_Unit_Tests;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {

        [TestMethod]
        public void EmptyTest() { Assert.AreEqual(10, 10, .001); }
        [TestMethod]
        public void GasTankFilled()
        {
            Car car = new Car("Toyota", "Supra", 16, 25);
            Assert.AreEqual(car.GasTankLevel, 16, .001);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        public void FuelUsage()
        {
            Car car = new Car("Toyota", "Supra", 16, 25);
            Assert.AreEqual(car.Drive(100).GasTankLevel,  )
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //TODO: can't have more gas than tank size, expect an exception

    }
}