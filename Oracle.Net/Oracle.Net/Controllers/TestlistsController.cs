using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Oracle.Net.Data;
using Oracle.Net.Models;

namespace Oracle.Net.Controllers
{
    public class TestlistsController : Controller
    {
        private readonly OracleContext _context;

        public TestlistsController(OracleContext context)
        {
            _context = context;
        }

        // GET: Testlists
        [Authorize(Roles = "teacher")]
        public  IActionResult Index()
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var classid = _context.User.First(item => item.PhoneNumber == phonenumber).Class;
            return View( _context.Testlist.Where(item => (item.Class == classid)).OrderBy(item => item.Scene));
        }


        // GET: Testlists/Create
        [Authorize(Roles = "teacher")]
        public IActionResult Create()
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var classid = _context.User.First(item => item.PhoneNumber == phonenumber).Class;
            ViewBag.Class = classid;
            return View();
        }

        // POST: Testlists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> Create([Bind("Id,Scene,Testname,Class,Info")] Testlist testlist)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testlist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testlist);
        }

        // GET: Testlists/Edit/5
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testlist = await _context.Testlist.FindAsync(id);
            if (testlist == null)
            {
                return NotFound();
            }
            return View(testlist);
        }

        // POST: Testlists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Scene,Testname,Class,Info")] Testlist testlist)
        {
            if (id != testlist.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testlist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestlistExists(testlist.Id))
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
            return View(testlist);
        }

        // GET: Testlists/Delete/5
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testlist = await _context.Testlist
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testlist == null)
            {
                return NotFound();
            }

            return View(testlist);
        }

        // POST: Testlists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testlist = await _context.Testlist.FindAsync(id);
            _context.Testlist.Remove(testlist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "teacher")]
        private bool TestlistExists(int id)
        {
            return _context.Testlist.Any(e => e.Id == id);
        }
    }
}
