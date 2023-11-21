using FlightController.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightController
{
 
    public class FlightControl
    {
        private SortedList<String,Flight> _flights;

        public FlightControl()
        {
            _flights = new SortedList<String, Flight>();
        }

        public void AddFlight(Flight flight) {
            if (_flights.ContainsKey(flight.getReference())) {
                throw new DuplicateFlightException();
            }
            _flights.Add(flight.getReference(),flight);
        }

        public Flight findFlightByReference(string reference)
        {
            
            if (_flights.Count == 0) {
                throw new FlightsSortedListIsEmptyException();
            }else if (!_flights.ContainsKey(reference))
            {
                throw new FlightNotFoundException();
            }

            return _flights[reference]; ;

        }

        public static void Main()
        {
            
        }
    }
}
