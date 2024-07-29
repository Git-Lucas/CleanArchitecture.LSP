using CleanArchitecture.LSP.Domain.DTOs;

namespace CleanArchitecture.LSP.Domain.Gateway;
public interface IRideHailingGateway
{
    string UriSufix { get; }

    Task<HttpResponseMessage> MakeRequestAsync(RequestTravelRequest request);
}
