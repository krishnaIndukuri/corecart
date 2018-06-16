using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace corecart
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeting, Greeting>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,IGreeting config,ILogger<Startup> logger)
        {
            var greeting = config.getGreetings();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }
            //app.Use(next =>
            //{
            //    return async context => {
            //       await context.Response.WriteAsync("HIT!!");
            //    };

            //    //return async context =>
            //    //{
            //    //    logger.LogInformation("Request Started");
            //    //    if(context.Request.Path.StartsWithSegments("/mym"))
            //    //    {
            //    //        await context.Response.WriteAsync("HIT!!");
            //    //        logger.LogInformation("Request handled..");
            //    //    }
            //    //    else
            //    //    {
            //    //        await next(context);
            //    //        logger.LogInformation("Request outgoing..");
            //    //    }
            //    //};
            //});
            //app.UseDefaultFiles();
            //app.UseStaticFiles();
            app.UseMvc(configureRoutes);
            //app.UseWelcomePage(new WelcomePageOptions {
            //    Path = "/wp"
            //});

            app.Run(async (context) =>
            {
                //throw new Exception();
                await context.Response.WriteAsync($"{greeting} and {env.EnvironmentName} ");
            });
        }

        private void configureRoutes(IRouteBuilder obj)
        {
            obj.MapRoute("Default", "{Controller=Home}/{Action=Index}/{Id?}");
        }
    }
}
