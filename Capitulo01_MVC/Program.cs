using Capitulo01_MVC.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var host = CreateHostBuilder(args).Build();

			
			//Comentado a pedido do livro na pagina 196
			/*using (var scope = host.Services.CreateScope())
			{
				var services = scope.ServiceProvider;
				try
				{
					var context = services.GetRequiredService<IESContext>();
					IESDbInitializer.Initialize(context);
				}
				catch (Exception ex)
				{
					var logger = services.GetRequiredService<ILogger<Program>>();
					logger.LogError(ex, "Um	erro	ocorreu	ao	popular  a   base    de  dados.");
				}
			}*/



			host.Run();
		}

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {

                    webBuilder.UseStartup<Startup>();
                });
    }
}
