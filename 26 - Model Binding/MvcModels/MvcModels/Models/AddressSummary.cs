using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MvcModels.Models
{
    //[Bind(nameof(City))]
    public class AddressSummary
    {
        //[BindNever]
        public string City { get; set; }

        public string Country { get; set; }
    }
}
