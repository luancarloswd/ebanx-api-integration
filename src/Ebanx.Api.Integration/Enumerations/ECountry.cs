using System.Runtime.Serialization;

namespace Ebanx.Api.Integration.Enumerations
{
    public enum ECountry
    {
        [EnumMember(Value = "br")] Brazil,
        [EnumMember(Value = "pe")] Peru,
        [EnumMember(Value = "mx")] Mexico,
        [EnumMember(Value = "co")] Colombia,
        [EnumMember(Value = "cl")] Chile,
        [EnumMember(Value = "ar")] Argentina,
        [EnumMember(Value = "ec")] Ecuador,
        [EnumMember(Value = "bo")] Bolivia
    }
}