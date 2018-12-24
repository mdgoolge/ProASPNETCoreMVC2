using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Models;
using DependencyInjection.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index() => View();

        //public ViewResult Index() => View(new MemoryRepository().Products);

        //public IRepository Repository { get; set; } = new MemoryRepository();
        //public IRepository Repository { get; } = TypeBroker.Repository;

        //private IRepository repository;
        //private ProductTotalizer totalizer;
        //public HomeController(IRepository repo) => repository = repo;
        //public HomeController(IRepository repo, ProductTotalizer total)
        //{
        //    repository = repo;
        //    totalizer = total;
        //    Console.WriteLine(repo.ToString());
        //}
        //public HomeController(IRepository repo) { repository = repo; }
        


        //public ViewResult Index() => View(Repository.Products);
        //public ViewResult Index()
        //{

        //    //ViewBag.Total = totalizer.Total;
        //    ViewBag.HomeController = repository.ToString();
        //    ViewBag.Totalizer = totalizer.Repository.ToString();
        //    return View(repository.Products);
        //}
        public ViewResult Index([FromServices]ProductTotalizer totalizer)
        {
            IRepository repository = HttpContext.RequestServices.GetService<IRepository>();

            ViewBag.HomeController = repository.ToString();
            ViewBag.Totalizer = totalizer.Repository.ToString();
            return View(repository.Products);
        }
    }
}
