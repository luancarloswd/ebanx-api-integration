namespace Ebanx.Api.Integration.Request
{
    public class SubAccount
    {
        /// <summary>
        /// Name of the sub account
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URL of the logo of the sub-account. PS: It MUST be an HTTPS URL. Otherwise, you will receive an error message.
        /// </summary>
        public string ImageUrl { get; set; }
    }
}