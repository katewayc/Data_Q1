using AutoMapper;
using data_format_Q1.Models;
using data_format_Q1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_format_Q1.App_Start
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