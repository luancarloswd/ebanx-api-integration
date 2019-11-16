using System.Runtime.Serialization;

namespace Ebanx.Api.Integration.Enumerations
{
    public enum EResponseStatus
    {
        [EnumMember(Value = "SUCCESS")] Success,
        [EnumMember(Value = "ERROR")] Error
    }
}