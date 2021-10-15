using ProiectMaster.Models.DTOs.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.Interfaces
{
    public interface IShoppingCartService
    {
        IEnumerable<ProductVM> GetAllProducts();
    }
}
