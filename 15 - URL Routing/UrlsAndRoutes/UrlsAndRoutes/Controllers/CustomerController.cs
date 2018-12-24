using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlsAndRoutes.Models;
namespace UrlsAndRoutes.Controllers
{
    //[Route("app/[controller]/actions/[action]/{id?}")]
    [Route("app/[controller]/actions/[action]/{id:weekday?}")]
    public class CustomerController : Controller
    {
        //[Route("myroute")]
        //[Route("[controller]/MyAction")]
        public ViewResult Index() => View("Result",
            new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(Index)
            });

        //public ViewResult List() => View("Result",
        //    new Result
        //    {
        //        Controller = nameof(CustomerController),
        //        Action = nameof(List)
        //    });
        public ViewResult List(string id)
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(List),
            }; r.Data["Id"] = id ?? "<no value>";
            r.Data["catchall"] = RouteData.Values["catchall"];
            return View("Result", r);
        }
    }
}
