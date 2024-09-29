using CleanArchitecture.LSP.Application.UseCases;
using CleanArchitecture.LSP.Domain.Util;
using System.Net;

namespace CleanArchitecture.LSP.Domain.RideHailings.Actions.RequestsTravel.OperationResult;
public record RequestTravelFailure(HttpStatusCode HttpStatusCode, string JsonString) : Result<RequestTravel>(false)
{
}
