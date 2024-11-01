using Boat;
using System.ComponentModel;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Boat.Boat boat = new Boat.Boat();
            List<Boat.Container> containers = new List<Boat.Container>();
            
            //Act
            containers.Add(new Boat.Container());

            //Assert
            Assert.IsNotNull(containers);

        }
        [TestMethod] 
        public void LoadMethod()
        {
            Boat.Boat boat = new Boat.Boat();
            Fridge fridge = new Fridge();
            boat.load(fridge);
        }
    }
}