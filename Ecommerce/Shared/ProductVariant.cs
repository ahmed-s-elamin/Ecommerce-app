using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Ecommerce.Shared
{
    public class ProductVariant
    {
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }

        [Column(TypeName = "decimal(18,2")]
        public int Price { get; set; }

        [Column(TypeName = "decimal(18,2")]
        public int OriginalPrice { get; set; }

    }
}
