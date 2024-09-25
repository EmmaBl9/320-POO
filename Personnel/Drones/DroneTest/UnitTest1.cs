using Drones ;
using System.Security.Cryptography.X509Certificates;
namespace DroneTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Drone drone;
            drone = new Drone();

            //Act : nothing

            //Assert
            Assert.AreEqual(1000, drone.Charge);

        }

        [TestMethod]
        public void TestLowBattery() 
        {
            //Arrange 
            Drone drone = new Drone();

            //Act : nothing 

            //Assert (la batterie n'est pas faible)
            Assert.IsFalse(drone.LowBattery);
        }
    }
}