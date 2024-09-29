using CleanArchitecture.LSP.Application.UseCases;
using CleanArchitecture.LSP.Domain.Util;

namespace CleanArchitecture.LSP;
public static class Controller
{
    private static readonly RequestTravel _useCase = new();

    public static async Task<Result<RequestTravel>> RequestTravelAsync(RequestTravelRequest request)
    {
        Result<RequestTravel> result = await _useCase.ExecuteAsync(request);

        return result;
    }
}
