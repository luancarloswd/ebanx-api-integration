using System.Runtime.Serialization;

namespace Ebanx.Api.Integration.Enumerations
{
    public enum ERefundStatus
    {
        /// <summary>
        /// The refund has been requested and is waiting to be processed. It can be cancelled while it has this status.
        /// </summary>
        [EnumMember(Value = "RE")] Requested,

        /// <summary>
        /// The refund is being processed.It cannot be cancelled anymore.
        /// </summary>
        [EnumMember(Value = "PE")] Pending,

        /// <summary>
        /// The refund was processed and the money was sent back to the customer.
        /// </summary>
        [EnumMember(Value = "CO")] Confirmed,

        /// <summary>
        /// The refund was cancelled.
        /// </summary>
        [EnumMember(Value = "CA")] Cancelled
    }
}