using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.AspNet.Routing.Template;
using Microsoft.Extensions.DependencyInjection;

namespace RoutingSample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();

            var routeBuilder = new RouteBuilder();

            routeBuilder.ServiceProvider = app.ApplicationServices;

            routeBuilder.Routes.Add(new TemplateRoute(
                new HelloRouter(),
                "hello/{name:alpha}",
                app.ApplicationServices.GetService<IInlineConstraintResolver>()));

            app.UseRouter(routeBuilder.Build());


            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
