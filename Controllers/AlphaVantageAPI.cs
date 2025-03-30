using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace WebFinancial.Controllers
{
    public class AlphaVantageAPI
    {
		private readonly string _apiKey;
		private readonly string _baseUrl = "https://www.alphavantage.co/query";

		public AlphaVantageAPI(string apiKey)
		{
			_apiKey = apiKey;
		}

		public async Task<string> GetForexDataAsync(string fromSymbol, string toSymbol, string outputsize = "compact")
		{
			using (HttpClient client = new HttpClient())
			{
				var url = $"{_baseUrl}?function=FX_DAILY&from_symbol={fromSymbol}&to_symbol={toSymbol}&outputsize={outputsize}&apikey={_apiKey}";

				try
				{
					HttpResponseMessage response = await client.GetAsync(url);
					response.EnsureSuccessStatusCode();

					string responseData = await response.Content.ReadAsStringAsync();
					return responseData; // Retorna os dados como string JSON
				}
				catch (Exception ex)
				{
					return $"Erro ao buscar os dados: {ex.Message}";
				}
			}
		}
	}
}
