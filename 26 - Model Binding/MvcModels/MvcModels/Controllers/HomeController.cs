using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcModels.Models;

namespace MvcModels.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repo) { repository = repo; }
        //public IActionResult Index(int? id)
        //{
        //    Person person;
        //    if (id.HasValue && (person = repository[id.Value]) != null)
        //    {
        //        return View(person);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }

        //}
        //public ViewResult Create() => View(new Person());
        //[HttpPost] public ViewResult Create(Person model) => View("Index", model);
        ////public ViewResult DisplaySummary(AddressSummary summary) => View(summary);
        //public ViewResult DisplaySummary(
        //     //[Bind(nameof(AddressSummary.City),Prefix = nameof(Person.HomeAddress))] AddressSummary summary)
        //     [Bind(Prefix = nameof(Person.HomeAddress))] AddressSummary summary)
        //    => View(summary);
        ////public ViewResult Names(string[] names) => View(names ?? new string[0]);
        //public ViewResult Names(IList<string>names)=>
        //    View(names ?? new List<string>());
        //public ViewResult Address(IList<AddressSummary> addresses) => View(addresses ?? new List<AddressSummary>());

        public IActionResult Index([FromQuery]int? id)
        {
            Person person;
            if (id.HasValue && (person = repository[id.Value]) != null)
            {
                return View(person);
            }
            else
            {
                return NotFound();
            }

        }
        //public string Header([FromHeader]string accept) => $"Header: {accept}";
        //public string Header([FromHeader(Name = "Accept-Language")] string accept) => $"Header: {accept}";
        public ViewResult Header(HeaderModel model) => View(model);

        public ViewResult Body() => View();
        [HttpPost]
        public Person Body([FromBody]Person model) => model;
    }
}
