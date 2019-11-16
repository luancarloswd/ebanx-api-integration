using Ebanx.Api.Integration.Enumerations;

namespace Ebanx.Api.Integration.Response
{
    public class TransactionStatus
    {
        /// <summary>
        /// The acquirer that processed the transaction.
        /// </summary>
        public string Acquirer { get; set; }

        public ECodeTrasactionStatus Code { get; set; }

        /// <summary>
        /// The description for the status code, which is returned from the acquirer.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Transaction authentication code in the acquirer.
        /// </summary>
        public string Authcode { get; set; }
    }
}