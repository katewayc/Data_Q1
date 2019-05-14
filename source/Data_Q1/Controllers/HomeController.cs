using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data_Q1.Models;
using Newtonsoft.Json;
using System.Globalization;
using Data_Q1.ViewModels;
using AutoMapper;

namespace Data_Q1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<Product> ProductList = new List<Product>();

            using (StreamReader r = new StreamReader(Server.MapPath(@"~/App_Data/data.json")))
            {
                string json = r.ReadToEnd();
                List<Product> items = JsonConvert.DeserializeObject<List<Product>>(json);
                ProductList = items;
            }

            List<ProductListViewModel> model = new List<ProductListViewModel>();

            foreach (var item in ProductList)
            {
                decimal result;
                if (decimal.TryParse(item.Promote_Price, out result))
                { item.Promote_Price = Convert.ToString(string.Format(new CultureInfo(GetCurrencyByLocale(item.Locale)), "{0:c}", decimal.Parse(item.Promote_Price))); }
                else
                { item.Promote_Price = "-"; }

                model.Add(new ProductListViewModel()
                {
                    Date1 = Convert.ToString(string.Format("{0:yyyy/MM/dd HH:mm:ss}", item.Date1)),
                    Product_Name = item.Product_Name,
                    Price = Convert.ToString(string.Format(new CultureInfo(GetCurrencyByLocale(item.Locale)), "{0:c}", item.Price)),
                    Promote_Price = item.Promote_Price
                });
            }

            var result_byAutoMapper = Mapper.Map<List<Product>, List<ProductListViewModel>>(ProductList);

            return View(model);

        }

        private string GetCurrencyByLocale(string locale)
        {
            string _currency = "";
            switch (locale)
            {
                case "US":
                    _currency = "en-US";
                    break;
                case "DE":
                    _currency = "de-DE";
                    break;
                case "CA":
                    _currency = "en-CA";
                    break;
                case "ES":
                    _currency = "es-ES";
                    break;
                case "FR":
                    _currency = "fr-FR";
                    break;
                case "JP":
                    _currency = "ja-JP";
                    break;
                default:
                    _currency = "en-US";
                    break;
            }
            return _currency;
        }
    }
}