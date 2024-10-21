using CleanArchitecture.LSP.Domain.Drivers.Entities;

namespace CleanArchitecture.LSP.Domain.Travels.Entities;
public class Travel(string usernameOfRequest, Driver driver, string sourceAddress, DateTime sourceTime, string destinationAddress)
{
    public string UsernameOfRequest { get; private set; } = usernameOfRequest;
    public Driver Driver { get; private set; } = driver;
    public string SourceAddress { get; private set; } = sourceAddress;
    public DateTime SourceTime { get; private set; } = sourceTime;
    public string DestinationAddress { get; private set; } = destinationAddress;
    public Guid TravelId { get; private set; }

    public void GenerateTravelId()
    {
        TravelId = Guid.NewGuid();
    }
}
