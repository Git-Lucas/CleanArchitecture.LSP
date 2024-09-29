using CleanArchitecture.LSP.Application.UseCases;
using CleanArchitecture.LSP.Domain.Util;

namespace CleanArchitecture.LSP.Domain.RideHailings.Actions.RequestsTravel.OperationResult;
public record RequestTravelSuccess() : Result<RequestTravel>(true)
{
    public Guid TravelId => Guid.NewGuid();
}
