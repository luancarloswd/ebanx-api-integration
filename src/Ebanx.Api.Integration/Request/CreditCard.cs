using System;

namespace Ebanx.Api.Integration.Request
{
    public class CreditCard
    {
        /// <summary>
        /// Credit card number.
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// Credit card cardholder name.
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// Credit card due date (“valid thru”) in the format mm/yyyy.
        /// </summary>
        public DateTime CardDueDate { get; set; }

        /// <summary>
        /// Credit card security code.
        /// </summary>
        public string CardCvv { get; set; }

        /// <summary>
        /// f true, the payment will be captured automatically by EBANX; if false, the payment will have to be captured by the merchant using the API method capture. The default value is true.k
        /// </summary>
        public bool AutoCapture { get; set; }

        /// <summary>
        /// If a previously created token is informed, no credit card information is needed. EBANX will identify the credit card associated with the token and perform the transaction. Only available if you do recurring billing.
        /// </summary>
        public string Token { get; set; }
    }
}