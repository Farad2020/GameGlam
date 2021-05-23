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
    public class DLCorLootDealsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DLCorLootDealsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DLCorLootDeals
        public async Task<IActionResult> Index()
        {
            List<DLCorLootDeal> dataList = new List<DLCorLootDeal>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://www.gamerpower.com/api/giveaways?type=loot"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    dataList = JsonConvert.DeserializeObject<List<DLCorLootDeal>>(apiResponse);
                }
            }
            return View(dataList);
           //return View(await _context.Enrollments.ToListAsync());
        }

        // GET: DLCorLootDeals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DLCorLootDeal dLCorLootDeal = new DLCorLootDeal();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://www.gamerpower.com/api/giveaway?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    dLCorLootDeal = JsonConvert.DeserializeObject<DLCorLootDeal>(apiResponse);
                }
            }
            if (dLCorLootDeal == null)
            {
                return NotFound();
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var items = _context.UserLoots.Where(e => e.userId == userId && e.gameId == dLCorLootDeal.id);
            if (items.Count() == 0)
            {
                ViewBag.isSaved = false;
            }
            else
            {
                ViewBag.isSaved = true;
            }

            return View(dLCorLootDeal);
        }


        public async Task<IActionResult> Save(String buttonAction, int itemId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var items = _context.UserLoots.Where(e => e.userId == userId && e.gameId == itemId);
            if (buttonAction == "save"
                && items.Count() == 0)
            {
                _context.UserLoots.Add(new UserLoot(userId, itemId));
                await _context.SaveChangesAsync();
            }
            else if (buttonAction == "unsave"
                && items.Count() > 0)
            {
                var userLoot = await _context.UserLoots.FindAsync(_context.UserLoots.SingleOrDefault(item => item.userId.Equals(userId) && item.gameId == itemId).id);
                _context.UserLoots.Remove(userLoot);
                await _context.SaveChangesAsync();
            }
            return Redirect("~/DLCorLootDeals/Details/" + itemId);
        }

        // GET: DLCorLootDeals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DLCorLootDeals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,title,worth,thumbnail,image,description,instructions,open_giveaway_url,published_date,type,platforms,end_date,users,status,gamerpower_url,open_giveaway")] DLCorLootDeal dLCorLootDeal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dLCorLootDeal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dLCorLootDeal);
        }

        // GET: DLCorLootDeals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dLCorLootDeal = await _context.DLCorLootDeals.FindAsync(id);
            if (dLCorLootDeal == null)
            {
                return NotFound();
            }
            return View(dLCorLootDeal);
        }

        // POST: DLCorLootDeals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,title,worth,thumbnail,image,description,instructions,open_giveaway_url,published_date,type,platforms,end_date,users,status,gamerpower_url,open_giveaway")] DLCorLootDeal dLCorLootDeal)
        {
            if (id != dLCorLootDeal.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dLCorLootDeal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DLCorLootDealExists(dLCorLootDeal.id))
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
            return View(dLCorLootDeal);
        }

        // GET: DLCorLootDeals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dLCorLootDeal = await _context.DLCorLootDeals
                .FirstOrDefaultAsync(m => m.id == id);
            if (dLCorLootDeal == null)
            {
                return NotFound();
            }

            return View(dLCorLootDeal);
        }

        // POST: DLCorLootDeals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dLCorLootDeal = await _context.DLCorLootDeals.FindAsync(id);
            _context.DLCorLootDeals.Remove(dLCorLootDeal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DLCorLootDealExists(int id)
        {
            return _context.DLCorLootDeals.Any(e => e.id == id);
        }

        public async Task<IActionResult> SavedLoot()
        {
            List<DLCorLootDeal> lootDeals = new List<DLCorLootDeal>();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var items = _context.UserLoots.Where(e => e.userId == userId).ToList();
            using (var httpClient = new HttpClient())
            {
                for (int i = 0; i < items.Count(); i++)
                {
                    using (var response = await httpClient.GetAsync("https://www.gamerpower.com/api/giveaway?id=" + items.ElementAt(i).gameId))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        lootDeals.Add(JsonConvert.DeserializeObject<DLCorLootDeal>(apiResponse));
                    }
                }
            }
            return View(lootDeals.AsEnumerable());
        }
    }
}
