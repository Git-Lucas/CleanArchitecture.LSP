using CleanArchitecture.LSP.Application.UseCases;
using System.Net;

namespace CleanArchitecture.LSP.Domain.OperationResult;
public record RequestTravelFailure(HttpStatusCode HttpStatusCode, string JsonString) : Result<RequestTravel>(false)
{
}
