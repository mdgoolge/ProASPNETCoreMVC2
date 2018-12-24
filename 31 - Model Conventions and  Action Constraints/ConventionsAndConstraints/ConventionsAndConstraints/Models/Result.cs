using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConventionsAndConstraints.Models
{
    public class Result
    {
        [Required]
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}
