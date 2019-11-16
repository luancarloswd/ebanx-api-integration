using System.Runtime.Serialization;

namespace Ebanx.Api.Integration.Enumerations
{
    public enum ECodeTrasactionStatus
    {
        /// <summary>
        /// The transaction amount was approved.
        /// </summary>
        [EnumMember(Value = "OK")] Ok,

        /// <summary>
        /// The acquirer did not approved the transaction. The customer must contact the issuer to check for any issue with his credit card.
        /// </summary>
        [EnumMember(Value = "NOK")] Nok,

        /// <summary>
        /// Something went wrong with the process. You can retry with the same data. We recommend you to try more 3 times on different periods of time (first try, then second try after 2 hours after the first, etc).k
        /// </summary>
        [EnumMember(Value = "RETRY")] Retry
    }
}