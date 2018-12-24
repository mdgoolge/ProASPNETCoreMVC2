using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    //[RequireHttps]
    //[HttpsOnly]
    //[Profile]
    //[ViewResultDetails]
    //[RangeException]
    //[TypeFilter(typeof(DiagnosticsFilter))]
    //[TypeFilter(typeof(TimeFilter))]
    //[TypeFilter(typeof(DiagnosticsFilter))]
    //[ServiceFilter(typeof(TimeFilter))] 
    [Message("This is the Controller-Scoped Filter", Order = 10)] 
    public class HomeController : Controller
    {
        //public ViewResult Index() => View("Message", "This is the Index action on the Home controller");

        //public IActionResult Index()
        //{
        //    if (!Request.IsHttps)
        //    {
        //        return new StatusCodeResult(StatusCodes.Status403Forbidden);
        //    }
        //    else
        //    {
        //        return View("Message", "This is the Index action on the Home controller");
        //    }
        //}

        //public IActionResult SecondAction()
        //{
        //    if (!Request.IsHttps)
        //    {
        //        //return View("Message", "Tadsfafdafdtroller");
        //        return new StatusCodeResult(StatusCodes.Status403Forbidden);
        //    }
        //    else
        //    {
        //        return View("Message", "This is the SecondAction action on the Home controller");
        //    }
        //}
        //[RequireHttps]
        [Message("This is the First Action-Scoped Filter", Order = 1)]
        [Message("This is the Second Action-Scoped Filter", Order = 1)]
        public ViewResult Index() => View("Message", "This is the Index action on the Home controller");
        //[RequireHttps]
        public ViewResult SecondAction() => View("Message", "This is the SecondAction action on the Home controller");

        public ViewResult GenerateException(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            else if (id > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }
            else
            {
                return View("Message", $"The value is {id}");
            }
        }

    }
}
