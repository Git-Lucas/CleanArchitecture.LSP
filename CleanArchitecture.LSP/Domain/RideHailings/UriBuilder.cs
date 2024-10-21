using CleanArchitecture.LSP.Domain.Travels.Entities;

namespace CleanArchitecture.LSP.Domain.RideHailings;
public static class UriBuilder
{
    public static string ResolveUri(Travel travel, string uriSufix)
    {
        uriSufix = uriSufix.Replace("{sourceAddress}", travel.SourceAddress);
        uriSufix = uriSufix.Replace("{sourceTime}", travel.SourceTime.ToString());
        uriSufix = uriSufix.Replace("{destinationAddress}", travel.DestinationAddress);

        return travel.Driver.DispatchUri + uriSufix;
    }
}
