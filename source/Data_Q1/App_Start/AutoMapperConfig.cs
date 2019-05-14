using AutoMapper;
using Data_Q1.Models;
using Data_Q1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Q1.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Product, ProductListViewModel>();

            });
        }
    }
}