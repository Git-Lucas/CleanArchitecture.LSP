using CleanArchitecture.LSP.Domain.Drivers.Entities;
using CleanArchitecture.LSP.Domain.RideHailings.Gateway;
using CleanArchitecture.LSP.Domain.Travels.Entities;
using CleanArchitecture.LSP.Infrastructure.RideHailingGateway;
using System.Net;

namespace CleanArchitecture.LSP.Application.UseCases;
public class RequestTravel
{
    public async Task<Result<RequestTravel>> ExecuteAsync(RequestTravelRequest request)
    {
        Travel travel = ToEntity(request);

        IRideHailingGateway rideHailling = RideHailingFactory.GetRideHailingGateway(request.Driver.DispatchUri);
        HttpResponseMessage httpResponseMessage = await rideHailling.MakeRequestAsync(travel);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            travel.GenerateTravelId();
            //Persist in database
            return new RequestTravelSuccess(travel.TravelId);
        }

        return new RequestTravelFailure(httpResponseMessage.StatusCode, await httpResponseMessage.Content.ReadAsStringAsync());
    }

    private static Travel ToEntity(RequestTravelRequest dto)
    {
        return new Travel(dto.UsernameOfRequest,
                          dto.Driver,
                          dto.SourceAddress,
                          dto.SourceTime,
                          dto.DestinationAddress);
    }
}

public record RequestTravelRequest(string UsernameOfRequest, Driver Driver, string SourceAddress, DateTime SourceTime, string DestinationAddress)
{
}

public record RequestTravelSuccess(Guid TravelId) : Result<RequestTravel>(true)
{
}

public record RequestTravelFailure(HttpStatusCode HttpStatusCode, string JsonString) : Result<RequestTravel>(false)
{
}
