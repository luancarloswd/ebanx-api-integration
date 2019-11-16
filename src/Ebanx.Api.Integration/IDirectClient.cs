using System.Threading.Tasks;
using Refit;

namespace Ebanx.Api.Integration
{
    public interface IDirectClient
    {
        [Post("https://sandbox.ebanxpay.com/ws/direct")]
        Task<Response.Response> SendRequestSandbox(Request.Request request);

        [Post("https://api.ebanxpay.com/ws/direct")]
        Task<Response.Response> SendRequest(Request.Request request);
    }
}