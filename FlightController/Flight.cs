public class Flight
{
    private String _reference;
    private DateTime _departureDate;
    private String _origin;
    private String _destination;

    public Flight(string reference, DateTime departureDate, string origin, string destination)
    {
        _reference = reference;
        _departureDate = departureDate;
        _origin = origin;
        _destination = destination;
    }

    public String getReference()
    {
        return _reference;
    }
    public DateTime getDepartureDate()
    {
        return _departureDate;
    }
    public String getOrigin()
    {
        return _origin;
    }
    public String getDestination()
    {
        return _destination;
    }

    public override bool Equals(object? obj)
    {
        return obj is Flight flight &&
               _reference == flight._reference &&
               _departureDate == flight._departureDate &&
               _origin == flight._origin &&
               _destination == flight._destination;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_reference, _departureDate, _origin, _destination);
    }

}