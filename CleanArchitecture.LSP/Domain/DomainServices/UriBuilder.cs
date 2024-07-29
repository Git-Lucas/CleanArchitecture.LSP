using CleanArchitecture.LSP.Domain.DTOs;

namespace CleanArchitecture.LSP.Domain.DomainServices;
public class UriBuilder
{
    private readonly Dictionary<string, string> _customUrisSufix = [];
    private readonly string _defaultUriSufix = "/pickupAddress/{sourceAddress}/pickupTime/{sourceTime}/destination/{destinationAddress}";

    public UriBuilder()
    {
        _customUrisSufix.Add("acme.com", "/pickupAddress/{sourceAddress}/pickupTime/{sourceTime}/dest/{destinationAddress}");
    }

    public string GetFullUri(RequestTravelRequest requestTravelRequest)
    {
        string? matchingKey = _customUrisSufix.Keys
            .FirstOrDefault(key => requestTravelRequest.Driver.DispatchUri.StartsWith(key, StringComparison.OrdinalIgnoreCase));

        if (matchingKey is not null && _customUrisSufix.TryGetValue(matchingKey, out string? customUriSufix))
        {
            return ResolveUri(requestTravelRequest, customUriSufix);
        }

        return ResolveUri(requestTravelRequest, _defaultUriSufix);
    }

    private static string ResolveUri(RequestTravelRequest requestTravelRequest, string uriSufix)
    {
        uriSufix = uriSufix.Replace("{sourceAddress}", requestTravelRequest.SourceAddres);
        uriSufix = uriSufix.Replace("{sourceTime}", requestTravelRequest.SourceTime.ToString());
        uriSufix = uriSufix.Replace("{destinationAddress}", requestTravelRequest.DestinationAddress);

        return requestTravelRequest.Driver.DispatchUri + uriSufix;
    }
}
