using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
namespace ConventionsAndConstraints.Infrastructure
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ActionNamePrefixAttribute : Attribute, IActionModelConvention
    {
        private string namePrefix;
        public ActionNamePrefixAttribute(string prefix) { namePrefix = prefix; }

        public void Apply(ActionModel action) { action.ActionName = namePrefix + action.ActionName; }
    }
}
