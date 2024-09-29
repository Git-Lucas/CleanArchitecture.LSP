using CleanArchitecture.LSP.Domain.RequestsTravel.Gateway;

namespace CleanArchitecture.LSP.Infrastructure.RideHailingGateway;
public static class RideHailingFactory
{
    public static IRideHailingGateway GetRideHailingGateway(string dispatchUri)
    {
        if (dispatchUri.StartsWith("acme.com"))
        {
            return new AcmeGateway(new HttpClient());
        }

        return new DefaultGateway(new HttpClient());
    }
}
