using CryptoApp.DTO;
using Newtonsoft.Json;

namespace CryptoApp.Services
{
    public class CryptoApiService : ICryptoApiService
    {

        public async Task<List<CryptoData>> GetAllCryptoMapAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://pro-api.coinmarketcap.com/v1/cryptocurrency/map?sort=cmc_rank&limit=30");
            request.Headers.Add("X-CMC_PRO_API_KEY", "d82de2b2-4fa9-427f-8883-ddd314a3c722");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());

            var result = await response.Content.ReadAsStringAsync();
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(result);
            return myDeserializedClass.data;

        }
    }
}
