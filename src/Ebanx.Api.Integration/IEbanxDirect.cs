using System.Threading.Tasks;

namespace Ebanx.Api.Integration
{
    public interface IEbanxDirect
    {
        Task<Response.Response> SendRequest(Request.Request request, bool isProduction = true);
    }
}