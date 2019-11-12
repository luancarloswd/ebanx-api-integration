namespace Ebanx.Api.Integration.Request
{
    public class Request
    {
        /// <summary>
        /// Your unique and secret integration key.
        /// </summary>
        public string IntegrationKey { get; set; }

        /// <summary>
        /// Must be request.
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// Currently only full mode is available.
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// A JSON object that represents the payment.
        /// </summary>
        public Payment Payment { get; set; }

        /// <summary>
        /// Optional parameter to tell EBANX to redirect the customer straight to the response URL after the payment is completed. This can be used in cases where the merchant will provide all the payment information in the response URL page.
        /// If this parameter is passed and equals to true then EBANX will not display the payment completed screen and will redirect the customer straight to the response URL, where the merchant must provide all the payment information. If the parameter is not provided or its value is not true, the payment completed screen will be displayed.
        /// </summary>
        public bool BypassBoletoScreen { get; set; }
    }
}