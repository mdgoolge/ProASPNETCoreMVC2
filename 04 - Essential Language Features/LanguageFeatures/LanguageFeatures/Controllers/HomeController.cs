using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    return View(new string[] { "C#", "Language", "Features" });
        //}

        //public ViewResult Index()
        //{
        //    List<string> results = new List<string>();
        //    foreach (Product p in Product.GetProducts())
        //    {
        //        string name = p?.Name;
        //        decimal? price = p?.Price;
        //        string relatedName = p?.Related?.Name;

        //        //results.Add(string.Format("Name:{0},Price:{1}", name, price));
        //        results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
        //    }
        //    return View(results);
        //}
        //public ViewResult Index()
        //{
        //    List<string> results = new List<string>();
        //    foreach (Product p in Product.GetProducts())
        //    {
        //        string name = p?.Name ?? "<No Name>";
        //        decimal? price = p?.Price ?? 0;
        //        string relatedName = p?.Related?.Name ?? "<None>";
        //        //results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
        //        results.Add($"Name:{name},Price:{price},Related:{relatedName}");

        //    }
        //    return View(results);
        //}

        //public ViewResult Index()
        //{
        //    object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
        //    decimal total = 0;
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        if (data[i] is decimal d)
        //        {
        //            total += d;
        //        }
        //    }
        //    return View("Index", new string[] { $"Total: {total:C2}" });
        //}

        /// <summary>
        /// Listing 4-18
        /// </summary>
        /// <returns></returns>
        //public ViewResult Index()
        //{
        //    object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
        //    decimal total = 0;
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        switch (data[i])
        //        {
        //            case decimal decimalValue:
        //                total += decimalValue;
        //                break;
        //            case int intValue when intValue > 50:
        //                total += intValue;
        //                break;
        //        }
        //    }
        //    return View("Index", new string[] { $"Total: {total:C2}" });
        //}
        //public ViewResult Index()
        //{
        //    ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
        //    decimal cartTotal = cart.TotalPrices();
        //    return View("Index", new string[] { $"Total: {cartTotal:C2}" });
        //}
        //public ViewResult Index()
        //{
        //    ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
        //    Product[] productArray = {
        //        new Product { Name = "Kayak", Price = 275M },
        //        new Product { Name = "Lifejacket", Price = 48.95M
        //        } };
        //    decimal cartTotal = cart.TotalPrices();
        //    decimal arrayTotal = productArray.TotalPrices();
        //    return View("Index", new string[] { $"Cart Total: {cartTotal:C2}", $"Array Total: {arrayTotal:C2}" });
        //}

        //Listing 4-26
        //public ViewResult Index()
        //{
        //    Product[] productArray = { new Product { Name = "Kayak", Price = 275M }, new Product { Name = "Lifejacket", Price = 48.95M }, new Product { Name = "Soccer ball", Price = 19.50M }, new Product { Name = "Corner flag", Price = 34.95M } };
        //    decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
        //    return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });
        //}
        //public ViewResult Index()
        //{
        //    Product[] productArray = { new Product { Name = "Kayak", Price = 275M }, new Product { Name = "Lifejacket", Price = 48.95M }, new Product { Name = "Soccer ball", Price = 19.50M }, new Product { Name = "Corner flag", Price = 34.95M } };
        //    decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices(); decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();
        //    return View("Index", new string[] { $"Price Total: {priceFilterTotal:C2}", $"Name Total: {nameFilterTotal:C2}" });
        //}
        //bool FilterByPrice(Product p) { return (p?.Price ?? 0) >= 20; }
        //public ViewResult Index()
        //{
        //    Product[] productArray = {
        //        new Product {Name = "Kayak", Price = 275M},                new Product {Name = "Lifejacket", Price = 48.95M},                new Product {Name = "Soccer ball", Price = 19.50M},                new Product {Name = "Corner flag", Price = 34.95M}            };
        //    Func<Product, bool> nameFilter = delegate (Product prod) { return prod?.Name?[0] == 'S'; };
        //    decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices(); decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrices();
        //    return View("Index", new string[] { $"Price Total: {priceFilterTotal:C2}", $"Name Total: {nameFilterTotal:C2}" });
        //}
        //public ViewResult Index()
        //{
        //    Product[] productArray = {
        //        new Product { Name = "Kayak", Price = 275M },
        //        new Product { Name = "Lifejacket", Price = 48.95M },
        //        new Product { Name = "Soccer ball", Price = 19.50M },
        //        new Product { Name = "Corner flag", Price = 34.95M } };
        //    decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
        //    decimal nameFilterTotal = productArray .Filter(p => p?.Name?[0] == 'S').TotalPrices();
        //    return View("Index", new string[] { $"Price Total: {priceFilterTotal:C2}", $"Name Total: {nameFilterTotal:C2}" });
        //}
        //public ViewResult Index() { return View(Product.GetProducts().Select(p => p?.Name)); }
        //public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));
        //public ViewResult Index() { var names = new[] { "Kayak", "Lifejacket", "Soccer ball" }; return View(names); }
        //public ViewResult Index()
        //{
        //    var products = new[] { new { Name = "Kayak", Price = 275M }, new { Name = "Lifejacket", Price = 48.95M }, new { Name = "Soccer ball", Price = 19.50M }, new { Name = "Corner flag", Price = 34.95M } };
        //    return View(products.Select(p => p.Name));
        //}
        //public ViewResult Index()
        //{
        //    var products = new[] { new { Name = "Kayak", Price = 275M }, new { Name = "Lifejacket", Price = 48.95M }, new { Name = "Soccer ball", Price = 19.50M }, new { Name = "Corner flag", Price = 34.95M } };
        //    return View(products.Select(p => p.GetType().Name));
        //}

        //public async Task<ViewResult> Index()
        //{
        //    long? length1 = await MyAsyncMethods.GetPageLength("http://apress.com");
        //    long? length2 = await MyAsyncMethods.GetPageLength("http://www.baidu.com");
        //    return View(new string[] { $"Length1: {length1},{length2 }" });
        //}

        //public ViewResult Index()
        //{
        //    var products = new[] { new { Name = "Kayak", Price = 275M }, new { Name = "Lifejacket", Price = 48.95M }, new { Name = "Soccer ball", Price = 19.50M }, new { Name = "Corner flag", Price = 34.95M } };
        //    return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
        //}
        public ViewResult Index()
        {
            var products = new[] { new { Name = "Kayak", Price = 275M }, new { Name = "Lifejacket", Price = 48.95M }, new { Name = "Soccer ball", Price = 19.50M }, new { Name = "Corner flag", Price = 34.95M } };
            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }





    }
}
