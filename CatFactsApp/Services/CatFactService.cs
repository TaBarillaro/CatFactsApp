using System.Net.Http;
using System.Text.Json;
using CatFactsApp.Models;

namespace CatFactsApp.Services
{
    public class CatFactService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        
        public async Task<CatFact> GetCatFactAsync()
        {
            string url = "https://catfact.ninja/fact";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            CatFact catFact = JsonSerializer.Deserialize<CatFact>(json);
            return catFact;
        }
    }
}
