using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameGlamer.Data;
using GameGlamer.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Security.Claims;

namespace GameGlamer.Controllers
{
    public class GameDealsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GameDealsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GameDeals
        public async Task<IActionResult> Index()
        {
            List<GameDeal> dataList = new List<GameDeal>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://www.gamerpower.com/api/giveaways?type=game"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    dataList = JsonConvert.DeserializeObject<List<GameDeal>>(apiResponse);
                }
            }
            return View(dataList);
        }

        // GET: GameDeals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GameDeal gameDeal = new GameDeal();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://www.gamerpower.com/api/giveaway?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    gameDeal = JsonConvert.DeserializeObject<GameDeal>(apiResponse);
                }
            }
            if (gameDeal == null)
            {
                return NotFound();
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var items = _context.UserGames.Where(e => e.userId == userId && e.gameId == gameDeal.id);
            if(items.Count() == 0)
            {
                ViewBag.isSaved = false;
            }
            else
            {
                ViewBag.isSaved = true;
            }

            return View(gameDeal);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(String buttonAction, int itemId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var items = _context.UserGames.Where(e => e.userId == userId && e.gameId == itemId);
            if (buttonAction == "save"
                && items.Count() == 0)
            {
                _context.UserGames.Add(new UserGame(userId, itemId));
                await _context.SaveChangesAsync();
            }
            else if (buttonAction == "unsave"
                && items.Count() > 0)
            {
                var userGame = await _context.UserGames.FindAsync(_context.UserGames.SingleOrDefault(item => item.userId.Equals(userId) && item.gameId == itemId).id);
                _context.UserGames.Remove(userGame);
                await _context.SaveChangesAsync();
            }
            return Redirect("~/GameDeals/Details/" + itemId);
        }

        // GET: GameDeals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GameDeals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,title,worth,thumbnail,image,description,instructions,open_giveaway_url,published_date,type,platforms,end_date,users,status,gamerpower_url,open_giveaway")] GameDeal gameDeal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameDeal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameDeal);
        }

        // GET: GameDeals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameDeal = await _context.GameDeals.FindAsync(id);
            if (gameDeal == null)
            {
                return NotFound();
            }
            return View(gameDeal);
        }

        // POST: GameDeals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,title,worth,thumbnail,image,description,instructions,open_giveaway_url,published_date,type,platforms,end_date,users,status,gamerpower_url,open_giveaway")] GameDeal gameDeal)
        {
            if (id != gameDeal.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameDeal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameDealExists(gameDeal.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gameDeal);
        }

        // GET: GameDeals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameDeal = await _context.GameDeals
                .FirstOrDefaultAsync(m => m.id == id);
            if (gameDeal == null)
            {
                return NotFound();
            }

            return View(gameDeal);
        }

        // POST: GameDeals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameDeal = await _context.GameDeals.FindAsync(id);
            _context.GameDeals.Remove(gameDeal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameDealExists(int id)
        {
            return _context.GameDeals.Any(e => e.id == id);
        }

        public async Task<IActionResult> SavedGames()
        {
            List<GameDeal> gameDeals = new List<GameDeal>();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var items = _context.UserGames.Where(e => e.userId == userId).ToList();
            using (var httpClient = new HttpClient())
            {
                for (int i = 0; i < items.Count(); i++)
                {
                    using (var response = await httpClient.GetAsync("https://www.gamerpower.com/api/giveaway?id=" + items.ElementAt(i).gameId))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        gameDeals.Add(JsonConvert.DeserializeObject<GameDeal>(apiResponse));
                    }
                }
            }
            return View(gameDeals.AsEnumerable());
        }


    }
}
