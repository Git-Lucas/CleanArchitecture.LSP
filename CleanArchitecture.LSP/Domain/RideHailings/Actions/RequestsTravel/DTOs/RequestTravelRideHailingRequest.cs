using CleanArchitecture.LSP.Domain.Drivers.Entities;

namespace CleanArchitecture.LSP.Domain.RideHailings.Actions.RequestsTravel.DTOs;
public record RequestTravelRideHailingRequest(Driver Driver, string SourceAddres, DateTime SourceTime, string DestinationAddress)
{
}
