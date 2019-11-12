using System.Runtime.Serialization;

namespace Ebanx.Api.Integration.Request.Enumerations
{
    public enum EPersonType
    {
        /// <summary>
        /// Corporation, legal entity.
        /// </summary>
        [EnumMember(Value = "business")] Business,

        /// <summary>
        /// Natural person.
        /// </summary>
        [EnumMember(Value = "personal")] Personal
    }
}