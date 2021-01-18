using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using PTemplate.Models.DataViewModel;
using Stimulsoft.Base;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace PTemplate.Areas.Admin.Controllers
{

    [Authorize(Roles = "Manager,Admin")]
    [Area("Admin")]
    public class Factor1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Factor1Controller(ApplicationDbContext context)
        {
            _context = context;
            StiLicense.LoadFromString("6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHl2AD0gPVknKsaW0un+3PuM6TTcPMUAWEURKXNso0e5OJN40hxJjK5JbrxU+NrJ3E0OUAve6MDSIxK3504G4vSTqZezogz9ehm+xS8zUyh3tFhCWSvIoPFEEuqZTyO744uk+ezyGDj7C5jJQQjndNuSYeM+UdsAZVREEuyNFHLm7gD9OuR2dWjf8ldIO6Goh3h52+uMZxbUNal/0uomgpx5NklQZwVfjTBOg0xKBLJqZTDKbdtUrnFeTZLQXPhrQA5D+hCvqsj+DE0n6uAvCB2kNOvqlDealr9mE3y978bJuoq1l4UNE3EzDk+UqlPo8KwL1XM+o1oxqZAZWsRmNv4Rr2EXqg/RNUQId47/4JO0ymIF5V4UMeQcPXs9DicCBJO2qz1Y+MIpmMDbSETtJWksDF5ns6+B0R7BsNPX+rw8nvVtKI1OTJ2GmcYBeRkIyCB7f8VefTSOkq5ZeZkI8loPcLsR4fC4TXjJu2loGgy4avJVXk32bt4FFp9ikWocI9OQ7CakMKyAF6Zx7dJF1nZw");
            //StiLicense.LoadFromString("6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHkcgIvwL0jnpsDqRpWg5FI5kt2G7A0tYIcUygBh1sPs7rE7BAeUEkpkjUKhl6/j24S6yxsIWZIRjJksEoLVUjBueVKUbrngXOqKSPJ8HE3n1pShqAKcqrYW8MlF8pB4nnRnYzLWJ/P+/p8zFGywvfSWm7L6hGvJFWozdlx5wLTj4K5UuclS2XfPNkIDrt7BY5X2KVdt42NBLZbM5RdUB8iJFobpp0HzoKZI8TSn++9s0y2cM/uGn0zHRcz/b8P/PiiOJkRkm0XlFrXG19KuA6eBAUfWiHYAgTMZq2UCyOdCbDZEcF8SqCGjboFuTyI7OHTQ4PVFQY8uEmsqhes9jqiz7u7Ts7Ndy88rVAe10GiHrBdyAGf4AR4G9DFrA10fnTGIVLixX8GpNTGgsLFIOf+IQOUvdcV39PeCf2JA2vEhSqbiaiftgGwxxgbc8ENPXijj+wYztDzMBeTJUwZBheNLcD2Rqwrc//HYvbuG6aZSjPCA5DvD3QJMvdBdHM3HWvlyU0tN6xVAiECAvWQdSOks");
        }

        public IActionResult PrintPage(string id="")
        {
            HttpContext.Session.SetString("idfactor", id);
         
            return View("PrintPage");
        }

        public IActionResult Print()
        {
            StiReport rep = new StiReport();
          
            var id = HttpContext.Session.GetString("idfactor");
            rep.Load(StiNetCoreHelper.MapPath(this, "wwwroot/Report/ReportTest.mrt"));
            rep["@id"] =Guid.Parse(id);
           
            return StiNetCoreViewer.GetReportResult(this,rep);
        }


        public IActionResult ViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }

            // GET: Admin/Factor1
            public async Task<IActionResult> Index(long? Idmenu = 0, int? paging = 1)
        {
            IQueryable<Factor1> applicationDbContext;
            if(Idmenu==0)
            {
                applicationDbContext = _context.Factors1
                    .Include(f => f.IdfactorstateNavigation)
                    //.Include(f => f.IduserNavigation)

                    .OrderByDescending(p=>p.Datecreate);
            }
            else
            {
                applicationDbContext = _context.Factors1
                    .Include(f => f.IdfactorstateNavigation)
                    //.Include(f => f.IduserNavigation)

                    .Where(p=>p.Idfactorstate== Idmenu)
                     .OrderByDescending(p => p.Datecreate); 
            }

           
            ViewData["Idfactorstate"] = new SelectList(_context.Factorstates, "Id", "Name");
            
            

            return View(await applicationDbContext.ToListAsync());
        }


       

        public IActionResult PrintB()
        {

            StiReport sti = new StiReport();
            sti.Load(StiNetCoreHelper.MapPath(this,"wwwroot/Report/address.mrt"));
            //var ppp =  _context.Factor1
            //        .Include(f => f.IdfactorstateNavigation)
            //        .Include(a => a.IdproductaddressNavigation)
            //        .FirstAsync();

           var addres = _context.Productaddresses.ToList();
            sti.Dictionary.Variables["variableName"].Value = "Yar";


            var report = StiReport.CreateNewReport();
            var path = StiNetCoreHelper.MapPath(this, "wwwroot/Report/address.mr");
            report.Load(path);

            return StiNetCoreReportResponse.ResponseAsPdf(report);
            //sti.RegData("st", addres);
            return StiNetCoreViewer.GetReportResult(this, sti);

        }


        public IActionResult GetReport()

        {

            StiReport report = new StiReport();

            report.Load(StiNetCoreHelper.MapPath(this, "Reports/SimpleList.mrt"));



            return StiNetCoreViewer.GetReportResult(this, report);

        }



        //public IActionResult ViewerEvent()

        //{

        //    return StiNetCoreViewer.ViewerEventResult(this);

        //}

  

        // GET: Admin/Factor1/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factor1 = await _context.Factors1
                .Include(f => f.IdfactorstateNavigation)
                //.Include(f => f.IduserNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factor1 == null)
            {
                return NotFound();
            }
            ViewData["iduser"] = id;
            var subFa = new subFactorViewModel();

            subFa.factor = factor1;
            subFa.factorsubs = await _context.Factorsubs

                .Include(f => f.IdfactorNavigation)
                .Include(f => f.IdproductNavigation)
                .Where(p => p.Idfactor == id)
                .ToListAsync();
            ViewData["Idfactorstate"] = new SelectList(_context.Factorstates, "Id", "Name", factor1.Idfactorstate);

            return View(subFa);
        }





        [HttpPost]

        public async Task<IActionResult> Upfactorstate(
             Factor1 factor1)
        {

            var selects = await _context.Factors1.FindAsync(factor1.Id);
            selects.Idfactorstate = factor1.Idfactorstate;
            _context.Factors1.Update(selects);
            await _context.SaveChangesAsync();

            ViewData["Idfactorstate"] = new SelectList(_context.Factorstates, "Id", "Name");
            return Redirect("/Admin/Factor1/Details/" + factor1.Id);
            //return View("Details", factor1.Id);

        }

        // GET: Admin/Factor1/Create
        public IActionResult Create()
        {
            ViewData["Idfactorstate"] = new SelectList(_context.Factorstates, "Id", "Name");
            //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id");
            return View();
        }

        // POST: Admin/Factor1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Iduser,Idfactorstate,Idstatebank,Isactive,Datecreate,Datechangestate,Addressreceiver")] Factor1 factor1)
        {
            if (ModelState.IsValid)
            {
                factor1.Id = Guid.NewGuid();
                _context.Add(factor1);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Factor1/Index");
            }
            ViewData["Idfactorstate"] = new SelectList(_context.Factorstates, "Id", "Name", factor1.Idfactorstate);
            //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id", factor1.Iduser);
            return View(factor1);
        }

        // GET: Admin/Factor1/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factor1 = await _context.Factors1.FindAsync(id);
            if (factor1 == null)
            {
                return NotFound();
            }
            ViewData["Idfactorstate"] = new SelectList(_context.Factorstates, "Id", "Name", factor1.Idfactorstate);
          //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id", factor1.Iduser);
            return View(factor1);
        }

        // POST: Admin/Factor1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Iduser,Idfactorstate,Idstatebank,Isactive,Datecreate,Datechangestate,Addressreceiver")] Factor1 factor1)
        {
            if (id != factor1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factor1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Factor1Exists(factor1.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Factor1/Index");
            }
            ViewData["Idfactorstate"] = new SelectList(_context.Factorstates, "Id", "Id", factor1.Idfactorstate);
            //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id", factor1.Iduser);
            return View(factor1);
        }

        // GET: Admin/Factor1/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factor1 = await _context.Factors1
                .Include(f => f.IdfactorstateNavigation)
                //.Include(f => f.IduserNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factor1 == null)
            {
                return NotFound();
            }

            return View(factor1);
        }

        // POST: Admin/Factor1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var factor1 = await _context.Factors1.FindAsync(id);
            _context.Factors1.Remove(factor1);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/Factor1/Index");
        }

        private bool Factor1Exists(Guid id)
        {
            return _context.Factors1.Any(e => e.Id == id);
        }
    }
}
