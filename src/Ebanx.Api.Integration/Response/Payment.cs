using System;
using Ebanx.Api.Integration.Enumerations;

namespace Ebanx.Api.Integration.Response
{
    public class Payment
    {
        /// <summary>
        /// The payment hash (EBANX unique identifier).
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// The payment PIN (EBANX and Customer unique identifier).
        /// </summary>
        public string Pin { get; set; }

        /// <summary>
        /// The country of the paymen
        /// </summary>
        public ECountry Country { get; set; }

        /// <summary>
        /// The payment hash Merchant Payment Code (unique merchant ID).
        /// </summary>
        public string MerchantPaymentCode { get; set; }

        /// <summary>
        /// The order number, optional identifier set by the merchant. You can have multiple payments with the same order number.
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// The payment status.
        /// </summary>
        public EPaymentStatus PaymentStatus { get; set; }

        /// <summary>
        /// The date and hour of the last status change.
        /// </summary>
        public DateTime StatusDate { get; set; }

        /// <summary>
        /// The date and hour of when the payment was created.
        /// </summary>
        public DateTime OpenDate { get; set; }

        /// <summary>
        /// The date and hour of when the payment was confirmed.
        /// </summary>
        public DateTime ConfirmDate { get; set; }

        /// <summary>
        /// The date and hour of when the payment was settled.
        /// </summary>
        public DateTime TransferDate { get; set; }

        /// <summary>
        /// The amount in local currency.
        /// </summary>
        public float AmountBr { get; set; }

        /// <summary>
        /// The tax amount in local currency (varies between countries).
        /// </summary>
        public float AmountIof { get; set; }

        /// <summary>
        /// The amount in the original currency.
        /// </summary>
        public float AmountExt { get; set; }

        /// <summary>
        /// The exchange rate used in the payment.
        /// </summary>
        public float CurrencyRate { get; set; }

        /// <summary>
        /// Three-letter code of the original currency.
        /// </summary>
        public string CurrencyExt { get; set; }

        /// <summary>
        /// Expiry date of the payment (not applicable to all payment methods).
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Number of instalments for the payment, default value is 1.
        /// </summary>
        public int Installments { get; set; }

        /// <summary>
        /// The code of the payment method. 
        /// </summary>
        public EPaymentTypeCode PaymentTypeCode { get; set; }

        /// <summary>
        /// A JSON object that represents the payment details.
        /// </summary>
        public Details Details { get; set; }

        /// <summary>
        /// A JSON object that represents the payment credit card transaction.
        /// </summary>
        public TransactionStatus TransactionStatus { get; set; }

        /// <summary>
        /// Flag that shows if a payment is pre-approved by the credit card acquirer.
        /// </summary>
        public bool PreApproved { get; set; }

        /// <summary>
        /// Flag that shows if a payment is ready to be captured. Applies only to credit cards when auto_capture is set to false. Some remarks on this attribute:
        /// A payment can only be captured if pre_approved value is true, which means that the payment has been pre approved by the credit card acquirer. Before capture, an authorized payment has status as PE (pending). After the capture, the status changes to CO (confirmed). A payment can only be captured if the status is PE (pending). *Payments must be captured in 4 (four) days, otherwise they are automatically cancelled.
        /// NOTE: It can be changed up to 5 (five) days.
        /// </summary>
        public bool CaptureAvailable { get; set; }

        /// <summary>
        /// The URL the customer should be redirected to. Applies to certain payment methods using the Direct API.
        /// </summary>
        public string RedirectUrl { get; set; }

        /// <summary>
        /// If the customer has an EBANX Account profile and it has balance enough to pay for the created boleto, the response will contain this parameter responsible for redirecting the customer to his EBANX Account page so he can pay the boleto with his available balance.
        /// </summary>
        public string PayWithBalanceUrl { get; set; }

        /// <summary>
        /// The boleto URL.
        /// </summary>
        public string BoletoUrl { get; set; }

        /// <summary>
        /// The boleto barcode number. (Boleto)
        /// </summary>
        public string BoletoBarcode { get; set; }

        /// <summary>
        /// The CIP URL. (PagoEfectivo)
        /// </summary>
        public string CipUrl { get; set; }

        /// <summary>
        /// The CIP code. (PagoEfectivo)
        /// </summary>
        public string CipCode { get; set; }
        
        
    }
}