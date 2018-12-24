using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlsAndRoutes.Areas.Admin.Models;

namespace UrlsAndRoutes.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class HomeController : Controller
    {
        private Person[] data = new Person[] {
                new Person { Name = "Alice", City = "London" },
                new Person { Name = "Bob", City = "Paris" },
                new Person { Name = "Joe", City = "New York" } };
        public ViewResult Index() => View(data);
    }

}
