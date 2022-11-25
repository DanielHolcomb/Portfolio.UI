using Core.HttpDynamo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.UI.Models;
using System.Text.Json;

namespace Portfolio.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public LudumDareGameData? LudumDareGameData { get; set; }
        public List<SteamGameData>? SteamGameData { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task OnGet()
        {
            LudumDareGameData = await HttpDynamo.GetRequestAsync<LudumDareGameData>(_httpClientFactory, "https://portfolioapi20221124122023.azurewebsites.net/Projects/LudumDare");
            SteamGameData = await HttpDynamo.GetRequestAsync<List<SteamGameData>>(_httpClientFactory, "https://portfolioapi20221124122023.azurewebsites.net/Projects/Steam");
        }
    }
}