using GameGlamer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GameGlamer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            HomeMainVM mainVM = new HomeMainVM();
            using (var httpClient = new HttpClient())
            {
                mainVM.topGames = getTopNGamesAsync(12, httpClient).Result;
                mainVM.top16Games = getTopNGamesAsync(16, httpClient).Result;
                mainVM.top16Loot = getTopNLootAsync(16, httpClient).Result;
            }

            return View(mainVM);
        }

        private async Task<IEnumerable<GameDeal>> getTopNGamesAsync(int n, HttpClient httpClient)
        {
            List<GameDeal> dataList = new List<GameDeal>();
            using (var response = await httpClient.GetAsync("https://www.gamerpower.com/api/giveaways?type=game&sort-by=popularity"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                dataList = JsonConvert.DeserializeObject<List<GameDeal>>(apiResponse);
            }

            while (dataList.Count > n)
            {
                dataList.RemoveAt(dataList.Count - 1);
            }

            return dataList;
        }

        private async Task<IEnumerable<DLCorLootDeal>> getTopNLootAsync(int n, HttpClient httpClient)
        {
            List<DLCorLootDeal> dataList = new List<DLCorLootDeal>();
            using (var response = await httpClient.GetAsync("https://www.gamerpower.com/api/giveaways?type=loot&sort-by=popularity"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                dataList = JsonConvert.DeserializeObject<List<DLCorLootDeal>>(apiResponse);
            }

            while(dataList.Count > n)
            {
                dataList.RemoveAt(dataList.Count - 1);
            }

            return dataList;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
