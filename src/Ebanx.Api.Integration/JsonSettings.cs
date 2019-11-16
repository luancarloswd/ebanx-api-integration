using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Ebanx.Api.Integration
{
    public static class JsonSettings
    {
        public static JsonSerializerSettings Settings => new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            },
            Converters = new JsonConverter[] {new StringEnumConverter()}
        };
    }
}