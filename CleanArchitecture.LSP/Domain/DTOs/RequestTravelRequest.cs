using CleanArchitecture.LSP.Domain.Entities;

namespace CleanArchitecture.LSP.Domain.DTOs;
public record RequestTravelRequest(Driver Driver, string SourceAddres, DateTime SourceTime, string DestinationAddress)
{
}
