using CleanArchitecture.LSP.Domain.RideHailings.Actions.RequestsTravel.DTOs;

namespace CleanArchitecture.LSP.Domain.RequestsTravel.Gateway;
public interface IRideHailingGateway
{
    string UriSufix { get; }

    Task<HttpResponseMessage> MakeRequestAsync(RequestTravelRideHailingRequest request);
}
