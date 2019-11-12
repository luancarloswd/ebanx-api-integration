using System;
using System.Collections.Generic;
using Ebanx.Api.Integration.Request.Enumerations;

namespace Ebanx.Api.Integration.Request
{
    public class Payment
    {
        /// <summary>
        /// Customer name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Customer email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Three-letter code of the payment currency.
        /// </summary>
        public ECurrency CurrencyCode { get; set; }

        /// <summary>
        /// The amount in the specified currency (currency_code). E.g.: 100.50
        /// </summary>
        public float AmountTotal { get; set; }

        /// <summary>
        /// The payment hash Merchant Payment Code (unique merchant ID).
        /// </summary>
        public string MerchantPaymentCode { get; set; }

        /// <summary>
        /// The code of the payment method.
        /// </summary>
        public EPaymentTypeCode PaymentTypeCode { get; set; }

        /// <summary>
        /// Customers document
        /// Brazil: requires a valid CPF (natural person taxpayer ID) or CNPJ (business taxpayer ID).
        /// Chile: requires a valid RUT (Registro Único Tributario).
        /// Colombia: requires a valid NIT / CC (Número de Identificación Tributaria).
        /// Argentina: requires a valid CUIT / CUIL / CDI (Clave Única de Identificación Tríbutaria).
        /// </summary>
        public string Document { get; set; }

        /// <summary>
        /// Customer’s IP adress. It may be used by an anti-fraud tool.
        /// </summary>
        public string CustomerIp { get; set; }

        /// <summary>
        /// Customer’s zipcode.
        /// Brazil: required.
        /// Argentina: required for Credit Card payments.
        /// Chile: required for Webpay payments.
        /// Colombia: required for Credit Card payments.
        /// Mexico: required for Credit Card payments.
        /// Peru: required for Credit Card payments.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Customer address (street name).
        /// Brazil: required.
        /// Argentina: required for Credit Card payments.
        /// Chile: required for Webpay payments.
        /// Colombia: required for Credit Card payments.
        /// Mexico: required for Credit Card payments.
        /// Peru: required for Credit Card payments.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Customer street number.
        /// Brazil: required.
        /// Argentina: required for Credit Card payments.
        /// Chile: required for Webpay payments.
        /// Colombia: required for Credit Card payments.
        /// Mexico: required for Credit Card payments.
        /// Peru: required for Credit Card payments.
        /// </summary>
        public string StreetNumber { get; set; }

        /// <summary>
        /// Extra address field for complimentary data.
        /// </summary>
        public string StreetComplement { get; set; }

        /// <summary>
        /// Customer city.
        /// Brazil: required.
        /// Argentina: required for Credit Card payments.
        /// Chile: required for Webpay payments.
        /// Colombia: required for Credit Card payments.
        /// Mexico: required for Credit Card payments.
        /// Peru: required for Credit Card payments.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Customer state/region/province.
        /// Brazil: required. The state abbreviation.
        /// Argentina: required for Credit Card payments..
        /// Chile: required for Webpay payments.
        /// Colombia: required for Credit Card payments.
        /// Mexico: required for Credit Card payments.
        /// Peru: required for Credit Card payments.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The two-letter country code for the customer country. 
        /// </summary>
        public ECountry Country { get; set; }

        /// <summary>
        /// Customer phone number. It is required for all countries.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        public string UserValue1 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        public string UserValue2 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        public string UserValue3 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        public string UserValue4 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        public string UserValue5 { get; set; }

        /// <summary>
        /// The due date of payments slips. Boletos issued in USD can have a maximum expiry period of three days; boletos issued in BRL can have an extended expiry date. The due date is based on local time of the country that the payment is generated.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Generates a token for recurring billing. This is only available for merchants that have requested recurring billing on their contracts.
        /// </summary>
        public bool CreateToken { get; set; }

        /// <summary>
        /// Choose the token you want to use for recurring billing. This is only available for merchants that have requested recurring billing on their contracts. Use this parameter only if create_token is true. NOTE: TOKENS EXPIRE AFTER 14 MONTHS OF ITS LAST USE.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// The number of instalments of the payment (from 1 to 12, depending on your contract and the country).
        /// Brazil: 1 to 12 (depending on your contract).
        /// Mexico: 1, 3, 6, 9 or 12 (depending on your contract).
        /// Colombia: 1 to 36 (depending on your contract).
        /// Argentina: 1 to 12 (depending on your contract).
        /// Peru: 1 to 48 (depending on your contract).
        /// </summary>
        public int Intallments { get; set; }

        /// <summary>
        /// Object containing the customers credit card information.
        /// </summary>
        public CreditCard Creditcard { get; set; }

        /// <summary>
        /// A note about the payment. The value of this parameter will be shown along with payment details.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// The object containing the sub account’s name. Required for payments where the sub account feature is being used.
        /// </summary>
        public SubAccount SubAccount { get; set; }

        /// <summary>
        /// Object containing the items of the order
        /// </summary>
        public IEnumerable<OrderItem> Items { get; set; }

        /// <summary>
        /// Unique ID to identify the customer’s device. Used for anti-fraud checking purposes.
        /// https://developers.ebanx.com/api-reference/full-api-documentation/ebanx-payment-2/ebanx-payment-guide/guide-using-device-fingerprint/
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Code for the customer’s bank. Only required for Colombia payments. You can retrieve the available codes from ws/getBankList operation(https://developers.ebanx.com/api-reference/full-api-documentation/ebanx-payment-2/payment-reference/reference-get-bank-list/).
        /// </summary>
        public string EftCode { get; set; }

        /// <summary>
        /// The URL to send notifications for this payment. If this field is filled, EBANX will notify using this URL instead of the configured one.
        /// </summary>
        public string NotificationUrl { get; set; }

        /// <summary>
        /// The URL to redirect the customer after the payment in the EBANX Payment Page. If this field is filled, EBANX will redirect the customer using this URL instead of the configured one
        /// </summary>
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Optional parameter that can be used to identify the type of customer.
        /// </summary>
        public EPersonType PersonType { get; set; }

        /// <summary>
        /// A JSON object that represents the responsible. Required if person_type = business.
        /// </summary>
        public Responsible Responsible { get; set; }
    }
}