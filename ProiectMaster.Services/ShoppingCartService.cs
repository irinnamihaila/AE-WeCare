using AutoMapper;
using ProiectMaster.DataAccess.Interfaces;
using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Entites;
using ProiectMaster.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Services
{
    class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository<Product, int> productRep;
        private readonly IMapper mapper;

        public ShoppingCartService(IRepository<Product, int> productRep, IMapper mapper)
        {
            this.productRep = productRep;
            this.mapper = mapper;
        }
        public IEnumerable<ProductVM> GetAllProducts()
        {
            var list = productRep.GetAll();
            return mapper.Map<List<ProductVM>>(list);
        }
    }
}
