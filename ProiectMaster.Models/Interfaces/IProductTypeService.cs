using ProiectMaster.Models.DTOs.VM;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMaster.Models.Interfaces
{
    public interface IProductTypeService
    {
        IEnumerable<ProductTypeVM> GetAllProductType();
        ProductTypeVM GetProductType(int id);
        void AddProductType(ProductTypeVM dto);
        void UpdateProductType(int id, ProductTypeVM dto);
        void DeleteProductType(int id);
    }
}
