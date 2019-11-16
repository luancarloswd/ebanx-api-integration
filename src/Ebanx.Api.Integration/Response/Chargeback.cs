using System;

namespace Ebanx.Api.Integration.Response
{
    public class Chargeback
    {
        /// <summary>
        /// The date and hour when the chargeback was imported into the system.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// The date and hour when the chargeback was created by the acquirer on behalf of the customer.
        /// </summary>
        public DateTime ChargebackDate { get; set; }

        /// <summary>
        /// Description of the chargeback.
        /// </summary>
        public string Description { get; set; }
    }
}