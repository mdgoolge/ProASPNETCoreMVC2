using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.AspNetCore.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(options => options.ConstraintMap.Add("weekday", typeof(WeekDayConstraint)));
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvc(routes =>
            //{
            //    //routes.MapRoute(name: "ShopSchema2", 
            //    //    template: "Shop/OldAction",
            //    //    defaults: new { controller = "Home", action = "Index" });


            //    //routes.MapRoute(name: "ShopSchema", 
            //    //    template: "Shop/{action}", 
            //    //    defaults: new { controller = "Home" });

            //    //routes.MapRoute("", "X{controller}/{action}");

            //    //routes.MapRoute(name: "default", 
            //    //    template: "{controller=Home}/{action=Index}");

            //    //routes.MapRoute(name: "",
            //    //    template: "Public/{controller=Home}/{action=Index}");

            //    //routes.MapRoute(name: "MyRoute",
            //    //    template: "{controller=Home}/{action=Index}/{id=DefaultId}");
            //    //routes.MapRoute(name: "MyRoute",
            //    //   template: "{controller=Home}/{action=Index}/{id?}/{*catchall}");

            //    //routes.MapRoute(name: "MyRoute", 
            //    //    template: "{controller=Home}/{action=Index}/{id:int?}");

            //    //routes.MapRoute(name: "MyRoute",
            //    //    template: "{controller}/{action}/{id?}", 
            //    //    defaults: new { controller = "Home", action = "Index" }, 
            //    //    constraints: new { id = new IntRouteConstraint() });

            //    //routes.MapRoute(name: "MyRoute", template: "{controller:regex(^H.*)=Home}/{action=Index}/{id?}");

            //    //routes.MapRoute(name: "MyRoute", template: "{controller=Home}/{action=Index}/{id:range(10,20)?}");

            //    //routes.MapRoute(name: "MyRoute", template: "{controller=Home}/{action=Index}" + "/{id:alpha:minlength(6)?}");

            //    //routes.MapRoute(name: "MyRoute",
            //    //    template: "{controller}/{action}/{id?}",
            //    //    defaults: new { controller = "Home", action = "Index" },
            //    //    constraints: new
            //    //    {
            //    //        id = new CompositeRouteConstraint(new IRouteConstraint[] {
            //    //            new AlphaRouteConstraint(),
            //    //            new MinLengthRouteConstraint(6) })
            //    //    });

            //    //routes.MapRoute(name: "MyRoute", 
            //    //    template: "{controller}/{action}/{id?}", 
            //    //    defaults: new { controller = "Home", action = "Index" },
            //    //    constraints: new { id = new WeekDayConstraint() });
            //    routes.MapRoute(name: "MyRoute",
            //        template: "{controller=Home}/{action=Index}/{id:weekday?}");
            //});
            app.UseMvcWithDefaultRoute();
        }
    }
    
}
