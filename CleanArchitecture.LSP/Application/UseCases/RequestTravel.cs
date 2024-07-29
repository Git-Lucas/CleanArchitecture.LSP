using CleanArchitecture.LSP.Domain.DomainServices;
using CleanArchitecture.LSP.Domain.DTOs;
using CleanArchitecture.LSP.Domain.OperationResult;
using UriBuilder = CleanArchitecture.LSP.Domain.DomainServices.UriBuilder;

namespace CleanArchitecture.LSP.Application.UseCases;
public class RequestTravel(RequestMaker requestMaker, UriBuilder uriBuilder)
{
    private readonly RequestMaker _requestMaker = requestMaker;
    private readonly UriBuilder _uriBuilder = uriBuilder;

    public async Task<Result<RequestTravel>> ExecuteAsync(RequestTravelRequest request)
    {
        string fullUri = _uriBuilder.GetFullUri(request);

        HttpResponseMessage httpResponseMessage = await _requestMaker.ExecuteAsync(fullUri);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            return new RequestTravelSuccess();
        }

        return new RequestTravelFailure(httpResponseMessage.StatusCode, await httpResponseMessage.Content.ReadAsStringAsync());
    }
}
