using ProiectMaster.Models.DTOs;
using ProiectMaster.Models.DTOs.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductVM> GetAllProducts();
        ProductVM GetProduct(int id);
        void AddProduct(ProductVM dto);
        void UpdateProduct(int id, ProductVM dto);
        void DeleteProduct(int id);
        List<IdNameDTO> GetProductTypes();

        //TODO
        ProductTypeVM GetProductType(int id);
    }
}
