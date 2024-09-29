using CleanArchitecture.LSP.Domain.RequestsTravel.Gateway;
using CleanArchitecture.LSP.Domain.RideHailings.Actions.RequestsTravel.DTOs;
using CleanArchitecture.LSP.Domain.RideHailings.Actions.RequestsTravel.OperationResult;
using CleanArchitecture.LSP.Domain.Util;
using CleanArchitecture.LSP.Infrastructure.RideHailingGateway;

namespace CleanArchitecture.LSP.Application.UseCases;
public class RequestTravel
{
    public async Task<Result<RequestTravel>> ExecuteAsync(RequestTravelRequest request)
    {
        IRideHailingGateway rideHailling = RideHailingFactory.GetRideHailingGateway(request.RequestTravelRideHailingRequest.Driver.DispatchUri);
        HttpResponseMessage httpResponseMessage = await rideHailling.MakeRequestAsync(request.RequestTravelRideHailingRequest);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            return new RequestTravelSuccess();
        }

        return new RequestTravelFailure(httpResponseMessage.StatusCode, await httpResponseMessage.Content.ReadAsStringAsync());
    }
}

public record RequestTravelRequest(string UsernameOfRequest, RequestTravelRideHailingRequest RequestTravelRideHailingRequest)
{
}
