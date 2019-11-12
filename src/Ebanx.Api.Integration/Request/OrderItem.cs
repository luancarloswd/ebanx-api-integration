namespace Ebanx.Api.Integration.Request
{
    public class OrderItem
    {
        /// <summary>
        /// SKU of the item
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// Name of the item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Price of the unity of the item
        /// </summary>
        public float UnitPrice { get; set; }

        /// <summary>
        /// Quantity of each item
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Type of the item
        /// </summary>
        public string Type { get; set; }
    }
}