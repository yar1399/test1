using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;

namespace PTemplate.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class botTelegramsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public botTelegramsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/botTelegrams
        public async Task<IActionResult> Index()
        {
            return View(await _context.BotTelegrams.ToListAsync());
        }

        // GET: Admin/botTelegrams/Details/5
        public async Task<IActionResult> Details()
        {
           
            var botTelegram = await _context.BotTelegrams
                .FirstOrDefaultAsync();
            if (botTelegram == null)
            {
                return NotFound();
            }

            return View(botTelegram);
        }

        // GET: Admin/botTelegrams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/botTelegrams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,namechanale,token,isactive,isactivesendauto,isactivediscription,isactivepost,isactiveproduct,description")] BotTelegram botTelegram)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(botTelegram);
                //await _context.SaveChangesAsync();
                return Redirect("/Admin/botTelegrams/Index");
            }
            return View(botTelegram);
        }

        // GET: Admin/botTelegrams/Edit/5
        public async Task<IActionResult> Edit()
        {
            

            var botTelegram = await _context.BotTelegrams.FirstOrDefaultAsync();
            if (botTelegram == null)
            {
                return NotFound();
            }
            return View(botTelegram);
        }

        // POST: Admin/botTelegrams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,namechanale,token,isactive,isactivesendauto,isactivediscription,isactivepost,isactiveproduct,description")] BotTelegram botTelegram)
        {
            if (id != botTelegram.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    botTelegram.Id = id;
                    _context.Update(botTelegram);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!botTelegramExists(botTelegram.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/botTelegrams/Index");
            }
            return View(botTelegram);
        }

        // GET: Admin/botTelegrams/Delete/5
        public async Task<IActionResult> Delete()
        {
          

            var botTelegram = await _context.BotTelegrams
                .FirstOrDefaultAsync();
            if (botTelegram == null)
            {
                return NotFound();
            }

            return View(botTelegram);
        }

        // POST: Admin/botTelegrams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var botTelegram = await _context.BotTelegrams.FindAsync(id);
            //_context.botTelegram.Remove(botTelegram);
            //await _context.SaveChangesAsync();
            return Redirect("/Admin/botTelegrams/Index");
        }

        private bool botTelegramExists(int id)
        {
            return _context.BotTelegrams.Any(e => e.Id == id);
        }
    }
}
