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
    public class UserRolesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserRolesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/UserRoles
        public async Task<IActionResult> Index(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();
            ViewData["IdUser"] = id;
            List<AspNetRole1> _1868_yarbaseContext = _context.sp_aspnetuserroleslist(id);
           var bes= _context.sp_UseridGet(id).FirstOrDefault();
            ViewData["email"] = "";
            if (bes == null)
                return Redirect("/Admin/Users/Index/" + id);
            ViewData["email"] = bes.Email;
            return View(_1868_yarbaseContext);
        }

        // GET: Admin/UserRoles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var aspNetUserRoles = await _context.AspNetUserRoles
            //    .Include(a => a.Role)
            //    .Include(a => a.User)
            //    .FirstOrDefaultAsync(m => m.UserId == id);
            //if (aspNetUserRoles == null)
            //{
            //    return NotFound();
            //}

            return View();

        }

        // GET: Admin/UserRoles/Create
        public IActionResult Create(string id)
        {

            if (string.IsNullOrEmpty(id))
                return NotFound();
            ViewData["IdUser"] = id;
            ViewData["RoleId"] = new SelectList(_context.sp_aspnetroleslist(), "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.sp_UseridGet(id), "Id", "Email");
            return View();
        }

        // POST: Admin/UserRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,RoleId")] AspNetUserRoles1 aspNetUserRoles)
        {
            if (ModelState.IsValid)
            {
                _context.sp_aspnetuserrolesinsert(aspNetUserRoles.UserId, aspNetUserRoles.RoleId);
                //_context.Add(aspNetUserRoles);
                //await _context.SaveChangesAsync();
                return Redirect("/Admin/UserRoles/Index/" + aspNetUserRoles.UserId);
            }
            ViewData["IdUser"] = aspNetUserRoles.UserId;
            //ViewData["RoleId"] = new SelectList(_context.AspNetRoles, "Id", "Name", aspNetUserRoles.RoleId);
            //ViewData["UserId"] = new SelectList(_context.AspNetUsers.Where(a=>a.Id== aspNetUserRoles.UserId), "Id", "Email", aspNetUserRoles.UserId);
            return View(aspNetUserRoles);
        }

        // GET: Admin/UserRoles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var aspNetUserRoles = await _context.AspNetUserRoles.FindAsync(id);
            //if (aspNetUserRoles == null)
            //{
            //    return NotFound();
            //}
            //ViewData["RoleId"] = new SelectList(_context.AspNetRoles, "Id", "Name", aspNetUserRoles.RoleId);
            //ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Email", aspNetUserRoles.UserId);
            return View();
        }

        // POST: Admin/UserRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserId,RoleId")] AspNetUserRoles1 aspNetUserRoles)
        {
            if (id != aspNetUserRoles.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(aspNetUserRoles);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AspNetUserRolesExists(aspNetUserRoles.UserId))
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
            //ViewData["RoleId"] = new SelectList(_context.AspNetRoles, "Id", "Name", aspNetUserRoles.RoleId);
            //ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Email", aspNetUserRoles.UserId);
            return View(aspNetUserRoles);
        }

        // GET: Admin/UserRoles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["IdUser"] = id;
          
            //if (aspNetUserRoles == null)
            //{
            //    return NotFound();
            //}

            return View();
        }

        //// POST: Admin/UserRoles/Delete/5
       // [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string iduser, string idrole)
        {
          
            _context.sp_spNetUserRolesDelete(iduser, idrole);
          
            return Redirect("/Admin/UserRoles/Index/" + iduser);
        }

        private bool AspNetUserRolesExists(string id)
        {
            return true;// _context.AspNetUserRoles.Any(e => e.UserId == id);
        }
    }
}
