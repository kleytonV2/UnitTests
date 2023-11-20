using FlightController;

namespace FlightControllerTest
{

    /* Flight Controller
     *  - Add flight
     *  - Get flight by reference
     *  - Get flight by origin
     *  - Get flight between two dates
     *  - Remove flight
     */


    [TestClass]
    public class UnitTest1
    {
        private FlightControl flightController;

        public void setup() 
        {
            flightController = new FlightControl();
        } 

        [TestMethod]
        public void GivenEmptyFlightController_WhenFlightAdded_ThenGettByReferenceReturnsFlight()
        {
            DateTime date = new DateTime(2022, 2, 11, 10, 30, 0);
            Flight flight = new Flight("1", date,"Madrid","Barcelona");

            flightController.AddFlight(flight);

            Assert.AreEqual(flight, flightController.findFlightByReference("1"));
        }
    }
}