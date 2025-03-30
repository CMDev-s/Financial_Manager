using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFinancial.Controllers;

namespace WebFinancial
{
    public class Program
    {
		//ATENÇÃO: Lixo de Intalação do Visual Studio
		//public static void Main(string[] args)
		//{
		//    CreateHostBuilder(args).Build().Run();
		//}

		//public static IHostBuilder CreateHostBuilder(string[] args) =>
		//    Host.CreateDefaultBuilder(args)
		//        .ConfigureWebHostDefaults(webBuilder =>
		//        {
		//            webBuilder.UseStartup<Startup>();
		//        });
		//Comentario de teste

		//CHAMADA API
		
		public static async Task Main(string[] args)
		{
			string apiKey = "NL4A7J42AZDAP4CG";
			string fromSymbol = "USD";
			string toSymbol = "BRL";

			AlphaVantageAPI api = new AlphaVantageAPI(apiKey);
			string data = await api.GetForexDataAsync(fromSymbol, toSymbol);

			Console.WriteLine(data);
		}
	}
}
