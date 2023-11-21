using FlightController;
using FlightController.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightControllerTest
{

    /* Flight Controller
     *  - Add flight
     *  - Get flight by reference
     */

    [TestClass]
    public class UnitTest1
    {
        private FlightControl flightController = new();

        [TestInitialize()]
        public void Startup()
        {
            flightController = new();
        }

        [TestMethod]
        public void GivenEmptyFlightController_WhenFlightAdded_ThenGettByReferenceReturnsFlight()
        {
            DateTime date = new DateTime(2022, 2, 11, 10, 30, 0);
            Flight flight = new Flight("1", date,"Madrid","Barcelona");

            flightController.AddFlight(flight);

            Assert.AreEqual(flight, flightController.findFlightByReference("1"));
        }

        [TestMethod]
        [ExpectedException(typeof(FlightNotFoundException))]
        public void GivenEmptyFlightController_WhenFindFlightByReference_ThenThrowFlightNOtFoundException()
        {
            DateTime date = new DateTime(2022, 2, 11, 10, 30, 0);
            Flight flight = new Flight("1", date, "Madrid", "Barcelona");

            flightController.AddFlight(flight);
            flightController.findFlightByReference("2");
        }

        [TestMethod]
        [ExpectedException(typeof(DuplicateFlightException))]
        public void GivenFlightControllerWithFlight_WhenSameFLightAdded_ThenThrowDuplicateFlightException()
        {
            DateTime date = new DateTime(2022, 2, 11, 10, 30, 0);
            Flight flight = new Flight("1", date, "Madrid", "Barcelona");

            flightController.AddFlight(flight);
            flightController.AddFlight(flight);
            flightController.findFlightByReference("1");
        }

    }
}