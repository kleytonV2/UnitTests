using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightController
{
    public class FlightControl
    {
        List<Flight> flights;

        public FlightControl()
        {
        }

        public FlightControl(Flight flight) {
            flights.Add(flight);
        }

        public Flight findFlightByReference(string reference)
        {
            //if (flights.Count == 0) throw new ;
            return flights.Where(f => f.getReference().Equals(reference)).FirstOrDefault();
        }
    }
}
