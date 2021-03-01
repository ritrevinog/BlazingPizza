using BlazingPizza.Server.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var Host = CreateHostBuilder(args).Build();

            // Recuperar un services (Startup.cs) de forma manual
            var ScopeFactory = Host.Services.GetRequiredService<IServiceScopeFactory>();
            using(var Scope = ScopeFactory.CreateScope())
            {
                var Context = Scope.ServiceProvider.GetRequiredService<PizzaStoreContext>();

                if (Context.Specials.Count() == 0)
                {
                    SeedData.Initialize(Context);
                }
            }
            
            Host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
