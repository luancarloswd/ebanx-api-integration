using System;
using Ebanx.Api.Integration.Enumerations;

namespace Ebanx.Api.Integration.Response
{
    public class Refund
    {
        /// <summary>
        /// The ID of the refund on EBANX.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The ID of the refund on the merchant system (optional).
        /// </summary>
        public string MerchantRefundCode { get; set; }

        /// <summary>
        /// The status of the refund
        /// </summary>
        public ERefundStatus Status { get; set; }

        /// <summary>
        /// The date and hour when the refund was created.
        /// </summary>
        public DateTime RequestDate { get; set; }

        /// <summary>
        /// The date and hour when the customer data was received
        /// </summary>
        public DateTime PendingDate { get; set; }

        /// <summary>
        /// The date and hour when the money was transferred to the customer.
        /// </summary>
        public DateTime ConfirmDate { get; set; }

        /// <summary>
        /// he refunded amount in the original currency.
        /// </summary>
        public float AmountExt { get; set; }

        /// <summary>
        /// Description of the refund reason.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A JSON object that represents a chargeback linked to this payment. This node will only be present if a chargeback was issued.
        /// </summary>
        public Chargeback Chargeback { get; set; }

        /// <summary>
        /// Flag that shows if a chargeback credit was issued.
        /// </summary>
        public bool ChargebackCredit { get; set; }

        /// <summary>
        /// (Only for SPEI payments) The customer’s CLABE account.
        /// </summary>
        public string ClabeAccount { get; set; }

        /// <summary>
        /// (Only for SPEI payments) The reference for the current payment.
        /// </summary>
        public string ClabeReference { get; set; }
    }
}