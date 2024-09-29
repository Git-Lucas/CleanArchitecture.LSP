using CleanArchitecture.LSP.Domain.RequestsTravel.Gateway;
using CleanArchitecture.LSP.Domain.RideHailings.Actions.RequestsTravel.DTOs;
using System.Net;
using UriBuilder = CleanArchitecture.LSP.Domain.Util.UriBuilder;

namespace CleanArchitecture.LSP.Infrastructure.RideHailingGateway;
public class DefaultGateway(HttpClient httpClient) : IRideHailingGateway
{
    public string UriSufix => "/pickupAddress/{sourceAddress}/pickupTime/{sourceTime}/destination/{destinationAddress}";

    private readonly HttpClient _httpClient = httpClient;

    public async Task<HttpResponseMessage> MakeRequestAsync(RequestTravelRideHailingRequest request)
    {
        string fullUri = UriBuilder.ResolveUri(request, UriSufix);

        //return await _httpClient.PostAsync(fullUri, null);
        return new HttpResponseMessage(HttpStatusCode.OK);
    }
}
