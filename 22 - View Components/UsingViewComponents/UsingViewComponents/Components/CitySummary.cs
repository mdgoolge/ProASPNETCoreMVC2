using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsingViewComponents.Models;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Html;

namespace UsingViewComponents.Components
{
    public class CitySummary : ViewComponent
    {
        private ICityRepository repository;
        public CitySummary(ICityRepository repo) { repository = repo; }
        //public string Invoke() { return $"{repository.Cities.Count()} cities, " 
        //        + $"{repository.Cities.Sum(c => c.Population)} people"; }
        public IViewComponentResult Invoke( bool showList)
        {
            //return View(new CityViewModel
            //{
            //    Cities = repository.Cities.Count(),
            //    Population = repository.Cities.Sum(c => c.Population)
            //});

            //return Content("This is a <h3><i>string</i></h3>");

            //return new HtmlContentViewComponentResult(new HtmlString("This is a <h3><i>string</i></h3>"));

            //string target = RouteData.Values["id"] as string;
            //var cities = repository.Cities
            //    .Where(city => target == null ||
            //        string.Compare(city.Country, target, true) == 0);
            //return View(new CityViewModel
            //{
            //    Cities = cities.Count(),
            //    Population = cities.Sum(c => c.Population)
            //});

            if (showList)
            {
                return View("CityList", repository.Cities);
            }
            else
            {
                return View(new CityViewModel
                {
                    Cities = repository.Cities.Count(),
                    Population = repository.Cities.Sum(c => c.Population)
                });
            }
        }
    }
}
