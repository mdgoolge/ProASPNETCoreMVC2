using ControllersAndActions.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace ControllersAndActions.Test
{
    public class UnitTest1
    {
        //[Fact]
        //public void Test1()
        //{
        //    // Arrange    
        //    ExampleController controller = new ExampleController();
        //    // Act   
        //    RedirectToRouteResult result = controller.Redirect();
        //    // Assert  
        //    Assert.False(result.Permanent);
        //    Assert.Equal("Example", result.RouteValues["controller"]);
        //    Assert.Equal("Index", result.RouteValues["action"]);
        //    Assert.Equal("MyID", result.RouteValues["ID"]);
        //}
        [Fact]
        public void Redirection()
        {    // Arrange  
            ExampleController controller = new ExampleController();
            // Act 
            RedirectToActionResult result = controller.Redirect();
            // Assert   
            Assert.False(result.Permanent);
            Assert.Equal("Index", result.ActionName);
        }

        //[Fact]
        //public void JsonActionMethod()
        //{    // Arrange   
        //    ExampleController controller = new ExampleController();
        //    // Act   
        //    JsonResult result = controller.Index();
        //    // Assert  
        //    Assert.Equal(new[] { "Alice", "Bob", "Joe" }, result.Value);
        //}

        [Fact]
        public void NotFoundActionMethod()
        {    // Arrange  
            ExampleController controller = new ExampleController();
            // Act  
            StatusCodeResult result = controller.Index();   
            // Assert 
            Assert.Equal(404, result.StatusCode);
        }

    }



}
