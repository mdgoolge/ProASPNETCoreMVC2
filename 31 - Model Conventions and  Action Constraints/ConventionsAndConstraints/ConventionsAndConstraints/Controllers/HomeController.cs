using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConventionsAndConstraints.Models;
using ConventionsAndConstraints.Infrastructure;

namespace ConventionsAndConstraints.Controllers
{
    //[AdditionalActions]
    public class HomeController : Controller
    {
        public IActionResult Index() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(Index) });
        //[ActionName("Details")]
        //[ActionNamePrefix("Do")]
        //[AddAction("Details")]
        [UserAgent("Edge")]
        public IActionResult List() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(List) });

        [UserAgent("Edge")]
        [ActionName("Index")]
        public IActionResult Other() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(Other) });

    }
}
