using CleanArchitecture.LSP.Domain.RideHailings.Actions.RequestsTravel.DTOs;

namespace CleanArchitecture.LSP.Domain.Util;
public static class UriBuilder
{
    public static string ResolveUri(RequestTravelRideHailingRequest requestTravelRequest, string uriSufix)
    {
        uriSufix = uriSufix.Replace("{sourceAddress}", requestTravelRequest.SourceAddres);
        uriSufix = uriSufix.Replace("{sourceTime}", requestTravelRequest.SourceTime.ToString());
        uriSufix = uriSufix.Replace("{destinationAddress}", requestTravelRequest.DestinationAddress);

        return requestTravelRequest.Driver.DispatchUri + uriSufix;
    }
}
