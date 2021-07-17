using NikeWebApp.Models;
using System.Collections.Generic;

namespace NikeWebApp.Interfaces
{
    public interface IProductDbOps
    {
        IEnumerable<Products> GetListOfAllProducts();
        Products GetProductById(int Id);
        bool AddProduct(Products Product);
    }
}
