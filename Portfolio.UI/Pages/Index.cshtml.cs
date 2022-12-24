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
        public List<DotNetData>? DotNetData { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task OnGet()
        {
            try
            {
                LudumDareGameData = await HttpDynamo.GetRequestAsync<LudumDareGameData>(_httpClientFactory, "https://portfolioapi20221124122023.azurewebsites.net/Projects/GameDev/LudumDare");
            }
            catch
            {
                LudumDareGameData = new LudumDareGameData();
            }
            try
            {
                SteamGameData = await HttpDynamo.GetRequestAsync<List<SteamGameData>>(_httpClientFactory, "https://portfolioapi20221124122023.azurewebsites.net/Projects/GameDev/Steam");
            }
            catch
            {
                SteamGameData = new List<SteamGameData>();
            }

            try
            {
                DotNetData = await HttpDynamo.GetRequestAsync<List<DotNetData>>(_httpClientFactory, "https://portfolioapi20221124122023.azurewebsites.net/Projects/WebDev/DotNet");
            }
            catch
            {
                DotNetData = new List<DotNetData>();
            }
            
        }
    }
}