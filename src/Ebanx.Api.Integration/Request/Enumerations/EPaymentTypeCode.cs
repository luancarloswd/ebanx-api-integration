using System.Runtime.Serialization;

namespace Ebanx.Api.Integration.Request.Enumerations
{
    public enum EPaymentTypeCode
    {
        /// <summary>
        /// American Express credit card (Brazil, Mexico, Colombia, Peru, Argentina).
        /// </summary>
        [EnumMember(Value = "amex")] Amex,

        /// <summary>
        /// Baloto (Colombia).
        /// </summary>
        [EnumMember(Value = "baloto")] Baloto,

        /// <summary>
        /// Bank transfer (Brazil).
        /// </summary>
        [EnumMember(Value = "banktransfer")] BankTransferBrazil,

        /// <summary>
        /// Banco do Brasil online debit (Brazil).
        /// </summary>
        [EnumMember(Value = "bancodobrasil")] BancoBrasil,

        /// <summary>
        /// Banrisul online debit (Brazil).
        /// </summary>
        [EnumMember(Value = "banrisul")] Banrisul,

        /// <summary>
        /// Boleto bancário (Brazil).
        /// </summary>
        [EnumMember(Value = "boleto")] Boleto,

        /// <summary>
        /// Bradesco online debit (Brazil).
        /// </summary>
        [EnumMember(Value = "bradesco")] Bradesco,

        /// <summary>
        /// Credit card (Brazil, Argentina, Mexico, Peru, Colombia).
        /// </summary>
        [EnumMember(Value = "creditcard")] CreditCard,

        /// <summary>
        /// Cupon de Pagos (Argentina).
        /// </summary>
        [EnumMember(Value = "cupon")] CuponPagos,

        /// <summary>
        /// EBANX Account (Brazil).
        /// </summary>
        [EnumMember(Value = "ebanxaccount")] EBANXAccount,

        /// <summary>
        /// Bank Transfer (Colombia).
        /// </summary>
        [EnumMember(Value = "eft")] BankTransferColombia,

        /// <summary>
        /// Itaú online debit (Brazil).
        /// </summary>
        [EnumMember(Value = "itau")] Itau,

        /// <summary>
        /// Multicaja (Chile).
        /// </summary>
        [EnumMember(Value = "multicaja")] Multicaja,

        /// <summary>
        /// OXXO (Mexico).
        /// </summary>
        [EnumMember(Value = "oxxo")] OXXO,

        /// <summary>
        /// PagoEfectivo (Peru).
        /// </summary>
        [EnumMember(Value = "pagoefectivo")] PagoEfectivo,

        /// <summary>
        /// PagoFacil (Argentina).
        /// </summary>
        [EnumMember(Value = "pagofacil")] PagoFacil,

        /// <summary>
        /// PagosNet (Bolivia).
        /// </summary>
        [EnumMember(Value = "pagosnet")] PagosNet,

        /// <summary>
        /// RapiPago (Argentina).
        /// </summary>
        [EnumMember(Value = "rapipago")] RapiPago,

        /// <summary>
        /// SafetyPay (Peru, Ecuador, Checkout only).
        /// </summary>
        [EnumMember(Value = "safetypay")] SafetyPay,

        /// <summary>
        /// SafetyPay Cash (Peru, Ecuador).
        /// </summary>
        [EnumMember(Value = "safetypay-cash")] SafetyPayCash,

        /// <summary>
        /// SafetyPay Online (Peru, Ecuador).
        /// </summary>
        [EnumMember(Value = "safetypay-online")]
        SafetyPayOnline,

        /// <summary>
        /// Sencillito (Chile).
        /// </summary>
        [EnumMember(Value = "sencillito")] Sencillito,

        /// <summary>
        /// Servipag (Chile).
        /// </summary>
        [EnumMember(Value = "servipag")] Servipag,

        /// <summary>
        /// SPEI bank transfer method (Mexico).
        /// </summary>
        [EnumMember(Value = "spei")] SPEI,

        /// <summary>
        /// Webpay (Chile).
        /// </summary>
        [EnumMember(Value = "webpay")] Webpay
    }
}