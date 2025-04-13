using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFinancial.Controllers;


using WebFinancial.ViewModels;

namespace WebFinancial
{
    public class Program
    {
		//ATENÇÃO: LIXO DE INTALAÇÃO DO VISUAL STUDIO

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
			var ViewModel = new AlphaVantageViewModel();
			string apiKey = ViewModel.ApiKey;
			string fromSymbol = "USD";
			string toSymbol = "BRL";

			AlphaVantageAPI api = new AlphaVantageAPI(apiKey);
			string data = await api.GetForexDataAsync(fromSymbol, toSymbol);

			Console.WriteLine(data);
		}
	}
}
