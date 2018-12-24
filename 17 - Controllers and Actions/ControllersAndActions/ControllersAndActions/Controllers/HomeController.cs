using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using ControllersAndActions.Infrastructure;
namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("SimpleForm");
        //public ViewResult ReceiveForm()
        //{
        //    var name = Request.Form["name"];
        //    var city = Request.Form["city"];
        //    return View("Result", $"{name} lives in {city}");
        //}
        //public ViewResult ReceiveForm(string name, string city)
        //    => View("Result", $"{name} lives in {city}");

        //public void ReceiveForm(string name,string city)
        //{
        //    Response.StatusCode = 200;
        //    Response.ContentType = "text/html";
        //    byte[] content = Encoding.ASCII
        //        .GetBytes($"<html><body>{name} lives in {city}</body></html>");
        //    Response.Body.WriteAsync(content, 0, content.Length);
        //}

        //public IActionResult ReceiveForm(string name, string city)
        //    => new CustomHtmlResult
        //    {
        //        Content = $"{name} lives in {city}"
        //    };

        //public ViewResult ReceiveForm(string name, string city)
        //    => View("Result", $"{name } lives in {city}");

        //[HttpPost] public RedirectToActionResult ReceiveForm(string name, string city) => RedirectToAction(nameof(Data));
        [HttpPost]
        public RedirectToActionResult ReceiveForm(string name, string city)
        {
            TempData["name"] = name;
            TempData["city"] = city;
            return RedirectToAction(nameof(Data));
        }

        //public ViewResult Data() => View("Result");
        public ViewResult Data()
        {
            string name = TempData["name"] as string;
            string city = TempData["city"] as string;
            return View("Result", $"{name} lives in {city}");
        }
    }
}
