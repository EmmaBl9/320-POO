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
            drone = new Drone(200,200);

            //Act : nothing

            //Assert
            Assert.AreEqual(1000, drone.Charge);

        }

        [TestMethod]
        public void TestLowBattery() 
        {
            //Arrange 
            Drone drone = new Drone(250,250);

            //Act : nothing 

            //Assert (la batterie n'est pas faible)
            Assert.IsFalse(drone.LowBattery);
        }

        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone(500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }

    }
}