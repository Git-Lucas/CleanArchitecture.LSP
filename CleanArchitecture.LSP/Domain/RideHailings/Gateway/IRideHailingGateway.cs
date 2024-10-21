using CleanArchitecture.LSP.Domain.Travels.Entities;

namespace CleanArchitecture.LSP.Domain.RideHailings.Gateway;
public interface IRideHailingGateway
{
    string UriSufix { get; }

    Task<HttpResponseMessage> MakeRequestAsync(Travel travel);
}
