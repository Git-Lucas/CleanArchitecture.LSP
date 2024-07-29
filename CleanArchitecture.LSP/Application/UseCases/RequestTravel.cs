using CleanArchitecture.LSP.Domain.DTOs;
using CleanArchitecture.LSP.Domain.Gateway;
using CleanArchitecture.LSP.Domain.OperationResult;

namespace CleanArchitecture.LSP.Application.UseCases;
public class RequestTravel(IRideHailingGateway rideHailling)
{
    private readonly IRideHailingGateway _rideHailling = rideHailling;

    public async Task<Result<RequestTravel>> ExecuteAsync(RequestTravelRequest request)
    {
        HttpResponseMessage httpResponseMessage = await _rideHailling.MakeRequestAsync(request);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            return new RequestTravelSuccess();
        }

        return new RequestTravelFailure(httpResponseMessage.StatusCode, await httpResponseMessage.Content.ReadAsStringAsync());
    }
}
