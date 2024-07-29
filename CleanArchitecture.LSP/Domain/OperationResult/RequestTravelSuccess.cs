using CleanArchitecture.LSP.Application.UseCases;

namespace CleanArchitecture.LSP.Domain.OperationResult;
public record RequestTravelSuccess() : Result<RequestTravel>(true)
{
    public Guid TravelId => Guid.NewGuid();
}
