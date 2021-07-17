using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NikeWebApp.Models
{
    public class ProductsModel
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<double> Price { get; set; }
        [DisplayName("Price")]
        public Nullable<double> SalePrice { get; set; }
        public byte[] Image { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<Products> ListOfAllProducts;
    }
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public double? SalePrice { get; set; }
        public byte[] Image { get; set; }
        public string ImageUrl { get; set; }
    }
}
