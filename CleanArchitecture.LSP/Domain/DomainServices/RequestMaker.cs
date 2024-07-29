using System.Net;

namespace CleanArchitecture.LSP.Domain.DomainServices;
public class RequestMaker(/*HttpClient httpClient*/)
{
    //private readonly HttpClient _httpClient = httpClient;

    public async Task<HttpResponseMessage> ExecuteAsync(string fullUri)
    {
        //return await _httpClient.PostAsync(fullUri, null);

        return new HttpResponseMessage(HttpStatusCode.OK);
    }
}
