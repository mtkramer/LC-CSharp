using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise7_Inheritance;

namespace Exercise7_Tests
{
    [TestClass]
    public class UnitTest1
    {
        // AbstractEntity Tests
        Computer computer = new Computer("Cyberpower PC", 3.3, 160);
        Laptop laptop = new Laptop("Alienware", 3.3, 160, "green");
        Smartphone smartphone = new Smartphone("LG Aristo", 1, 100);

        [TestMethod]
        public void IdShouldUpdate()
        {
            Assert.AreEqual(1, computer.id, .001);
            Assert.AreEqual(2, laptop.id, .001);
            Assert.AreEqual(3, smartphone.id, .001);
        }

        // Computer Tests
        [TestMethod]
        public void ComputerUseShouldWriteProperly()
        {
            Assert.AreEqual("Beeb, beep, beep at 3.3Ghz speed.", computer.Use());
        }
        [TestMethod]
        public void ComputerStorageShouldReflectChanges()
        {
            Assert.AreEqual(
                "Storing 40Gbytes... There is now 120Gb of free storage",
                computer.Store(40)
            );
        }
        [TestMethod]
        public void ComputerShouldRejectOverstorage()
        {
            Assert.AreEqual("Not enough memory! Only 160Gb remain.", computer.Store(200));
        }

        // Laptop Tests
        [TestMethod]
        public void LaptopShouldInheritComputerConstructor()
        {
            Assert.AreEqual("Alienware", laptop.Model);
        }
        [TestMethod]
        public void LaptopShouldHaveColor()
        {
            Assert.AreEqual("green", laptop.Color);
        }
        [TestMethod]
        public void LaptopShouldShareProperly()
        {
            Assert.AreEqual("Look at my green Alienware laptop!", laptop.Share());
        }

        // Smartphone Tests
        [TestMethod]
        public void SmartphoneCallNumberRejectsInvalidLengths()
        {
            Assert.AreEqual("Cannot dial 2, try again.", smartphone.CallNumber("2"));
        }
        [TestMethod]
        public void SmartphoneShouldUseCallNumberProperly()
        {
            Assert.AreEqual("Number 8134007116 was entered.", smartphone.CallNumber("8134007116"));
        }
        [TestMethod]
        public void SmartphoneShouldDialCorrectly()
        {
            smartphone.CallNumber("8134007116");
            Assert.AreEqual("Dialing 8134007116...", smartphone.Dial());
        }
    }
}
