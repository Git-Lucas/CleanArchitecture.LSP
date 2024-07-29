using CleanArchitecture.LSP.Application.UseCases;
using CleanArchitecture.LSP.Domain.DTOs;
using CleanArchitecture.LSP.Domain.OperationResult;
using CleanArchitecture.LSP.Infrastructure.RideHailingGateway;

namespace CleanArchitecture.LSP;
public static class Controller
{
    public static async Task<Result<RequestTravel>> RequestTravelAsync(RequestTravelRequest request)
    {
        RequestTravel useCase = new(RideHailingFactory.GetRideHailingGateway(request.Driver.DispatchUri));

        Result<RequestTravel> result = await useCase.ExecuteAsync(request);

        return result;
    }
}
