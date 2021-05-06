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

            return View(gameDeal);
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

            var gameDeal = await _context.Courses.FindAsync(id);
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

            var gameDeal = await _context.Courses
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
            var gameDeal = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(gameDeal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameDealExists(int id)
        {
            return _context.Courses.Any(e => e.id == id);
        }
    }
}
