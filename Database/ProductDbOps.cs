using NikeWebApp.Interfaces;
using NikeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NikeWebApp.Database
{
    public class ProductDbOps: IProductDbOps
    {
        public ProductDbOps(NikeDbContext productManagementDbContext)
        {
            _productDbContext = productManagementDbContext;
        }
        protected NikeDbContext _productDbContext;

        public IEnumerable<Products> GetListOfAllProducts()
        {
            var prodById = (from product in _productDbContext.Products
                            select product);
            if (prodById != null)
            {
                var ListOfAllProducts = prodById
                                           .Select(a => new Products()
                                           {
                                               Id = a.Id,
                                               Name = a.Name,
                                               Description = a.Description,
                                               Image = a.Image,
                                               ImageUrl = a.ImageUrl,
                                               Price = a.Price,
                                               SalePrice = a.SalePrice
                                           });
                return ListOfAllProducts;
            }
            else
            {
                return null;
            }
        }

        public Products GetProductById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool AddProduct(Products Product)
        {
            throw new NotImplementedException();
        }
        //3. Get All products based on search criteria

    }
}
