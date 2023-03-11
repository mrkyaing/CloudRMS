using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data
{
    [Table("Product")]
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double UnitPrice { get; set; }
    }
}
