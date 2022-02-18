using System.Runtime.Serialization;

namespace GuitarShop.Models
{
    public enum available
    {
        InStock,
        OutOfStock,
        OnOrder
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public available Availability { get; set; }
        public string Slug => Name.Replace(' ', '-');
    }
}