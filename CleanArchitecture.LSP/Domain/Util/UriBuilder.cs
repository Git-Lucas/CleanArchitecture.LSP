using CleanArchitecture.LSP.Domain.DTOs;

namespace CleanArchitecture.LSP.Domain.Util;
public static class UriBuilder
{
    public static string ResolveUri(RequestTravelRequest requestTravelRequest, string uriSufix)
    {
        uriSufix = uriSufix.Replace("{sourceAddress}", requestTravelRequest.SourceAddres);
        uriSufix = uriSufix.Replace("{sourceTime}", requestTravelRequest.SourceTime.ToString());
        uriSufix = uriSufix.Replace("{destinationAddress}", requestTravelRequest.DestinationAddress);

        return requestTravelRequest.Driver.DispatchUri + uriSufix;
    }
}
