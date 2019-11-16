using System.Runtime.Serialization;

namespace Ebanx.Api.Integration.Enumerations
{
    public enum EPaymentStatus
    {
        /// <summary>
        /// the customer has not yet filled the payment details on the EBANX Checkout. It can change either to CA (time out) or PE.
        /// </summary>
        [EnumMember(Value = "OP")]
        Unfilled, 
        /// <summary>
        /// the payment is pending confirmation. It can change either to CA or CO.
        /// </summary>
        [EnumMember(Value = "PE")]
        Pending,
        /// <summary>
        /// the payment is confirmed (paid).
        /// </summary>
        [EnumMember(Value = "CO")]
        Confirmed,
        /// <summary>
        /// the payment is cancelled.
        /// </summary>
        [EnumMember(Value = "CA")]
        Cancelled
    }
}