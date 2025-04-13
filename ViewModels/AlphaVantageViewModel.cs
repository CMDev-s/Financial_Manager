using System.Net.NetworkInformation;

namespace WebFinancial.ViewModels
{
    public class AlphaVantageViewModel
    {
        private string _apiKey = "NL4A7J42AZDAP4CG"; //OBS: Caso altere essa chave favor alterar na AlphaVantageAPI
                                                     //(Como forma de segurança, podemos adicionar essa chave em um arquivo .config ou no Azure Key Vault da vida,
                                                     //que são aplicaçoes em nuvem direcionadas para armazenar segredos em um cofre de chaves.

        public string ApiKey
        {
            get { 
                return _apiKey; 
            }
            set { 
                _apiKey = value; 
            }
        }
    }
}
