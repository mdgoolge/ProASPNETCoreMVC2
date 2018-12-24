using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingViewComponents.Models;

namespace UsingViewComponents.Components
{
    public class PocoViewComponent
    {
        private ICityRepository repository;
        public PocoViewComponent(ICityRepository repo) { repository = repo; }
        public string Invoke() {
            return $"{repository.Cities.Count()} cities, " 
                + $"{repository.Cities.Sum(c => c.Population)} people"; }
    }
}
