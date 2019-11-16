using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace Ebanx.Api.Integration
{
    public class EbanxDirect : IEbanxDirect
    {
        private readonly HttpClient _client;

        public EbanxDirect(HttpClient client) => _client = client;

        /// <summary>
        /// Send payment request for Ebanx Direct
        /// </summary>
        /// <param name="request">Request Object</param>
        /// <param name="isProduction">Signals production enviroment</param>
        /// <returns></returns>
        public async Task<Response.Response> SendRequest(Request.Request request, bool isProduction = true)
        {
            var client = CreateClient();

            return isProduction ? await client.SendRequest(request) : await client.SendRequestSandbox(request);
        }

        private IDirectClient CreateClient()
            => RestService.For<IDirectClient>(_client, new RefitSettings
            {
                ContentSerializer = new JsonContentSerializer(JsonSettings.Settings)
            });
    }
}