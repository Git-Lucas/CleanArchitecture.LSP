using CleanArchitecture.LSP.Domain.RideHailings.Gateway;
using CleanArchitecture.LSP.Domain.Travels.Entities;
using System.Net;
using UriBuilder = CleanArchitecture.LSP.Domain.RideHailings.UriBuilder;

namespace CleanArchitecture.LSP.Infrastructure.RideHailingGateway;
public class AcmeGateway(HttpClient httpClient) : IRideHailingGateway
{
    public string UriSufix => "/pickupAddress/{sourceAddress}/pickupTime/{sourceTime}/dest/{destinationAddress}";

    private readonly HttpClient _httpClient = httpClient;

    public async Task<HttpResponseMessage> MakeRequestAsync(Travel travel)
    {
        string fullUri = UriBuilder.ResolveUri(travel, UriSufix);

        //return await _httpClient.PostAsync(fullUri, null);
        return new HttpResponseMessage(HttpStatusCode.OK);
    }
}
