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
    [Authorize(Roles = "Manager,Admin")]
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Users
        public IActionResult Index(string id)
        {

            List<AspNetUsers1> user = new List<AspNetUsers1>();


            if (string.IsNullOrEmpty(id))
            {
                user = _context.sp_UserAllGet();
            }
            else
            {
                user = _context.sp_AspNetUserslikeEmail(id);
            }

            return View(user);
        }

        // GET: Admin/Users/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var aspNetUsers = await _context.AspNetUsers
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (aspNetUsers == null)
            //{
            //    return NotFound();
            //}

            return View();
        }

        // GET: Admin/Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AspNetUsers1 aspNetUsers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aspNetUsers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aspNetUsers);
        }

        // GET: Admin/Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return Redirect("/Admin/Users/Index");
            }

            var aspNetUsers =  _context.sp_UseridGet(id).FirstOrDefault();
            if (aspNetUsers == null)
            {
                return Redirect("/Admin/Users/Index");
            }
            return View(aspNetUsers);
        }

        // POST: Admin/Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AspNetUsers1 aspNetUsers)
        {
            if (id != aspNetUsers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var User = _context.sp_UseridGet(id).FirstOrDefault();
                    if (User != null)
                    {
                        User.UserName = aspNetUsers.UserName;
                        User.LockoutEnabled = aspNetUsers.LockoutEnabled;
                        User.NormalizedUserName = aspNetUsers.UserName.ToLower();
                        User.EmailConfirmed = aspNetUsers.EmailConfirmed;
                        User.PhoneNumberConfirmed = aspNetUsers.PhoneNumberConfirmed;
                        User.AccessFailedCount = aspNetUsers.AccessFailedCount;
                        User.TwoFactorEnabled = aspNetUsers.TwoFactorEnabled;

                        _context.sp_aspnetusersupdate(User);

                        return Redirect("/Admin/Users/Index");
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AspNetUsersExists(aspNetUsers.Id))
                    {
                        return Redirect("/Users/Index");
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Users/Index");
            }
            return View(aspNetUsers);
        }

        // GET: Admin/Users/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var aspNetUsers = await _context.AspNetUsers
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (aspNetUsers == null)
            //{
            //    return NotFound();
            //}

            return View();
        }

        // POST: Admin/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            //var aspNetUsers = await _context.AspNetUsers.FindAsync(id);
            //_context.AspNetUsers.Remove(aspNetUsers);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AspNetUsersExists(string id)
        {
            return true;// _context.AspNetUsers.Any(e => e.Id == id);
        }
    }
}
