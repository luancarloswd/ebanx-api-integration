using System.Runtime.Serialization;

namespace Ebanx.Api.Integration.Request.Enumerations
{
    public enum ECurrency
    {
        [EnumMember(Value = "BRL")] Brl,
        [EnumMember(Value = "EUR")] Eur,
        [EnumMember(Value = "MXN")] Mxn,
        [EnumMember(Value = "PEN")] Pen,
        [EnumMember(Value = "USD")] Usd,
        [EnumMember(Value = "CLP")] Clp,
        [EnumMember(Value = "COP")] Cop,
        [EnumMember(Value = "ARS")] Ars,
        [EnumMember(Value = "BOB")] Bob
    }
}