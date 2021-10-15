using AutoMapper;
using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMaster.Models
{
     public static class MapperConfig
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductType, ProductTypeVM>();
                cfg.CreateMap<ProductTypeVM, ProductType>();

                cfg.CreateMap<ProductVM, Product>();
                cfg.CreateMap<Product, ProductVM>();

                cfg.CreateMap<FeedbackVM, Feedback>();
                cfg.CreateMap<Feedback, FeedbackVM>();
            });
            return config.CreateMapper();
        }
    }
}
