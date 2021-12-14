using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ResturentWebsite.Data;
using ResturentWebsite.Models;

namespace ResturentWebsite.Controllers
{
    [Authorize]
    public class OurTeamController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OurTeamController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OurTeam
        public async Task<IActionResult> Index()
        {
            return View(await _context.OurTeam.ToListAsync());
        }
        [AllowAnonymous]
        // GET: OurTeam/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourTeam = await _context.OurTeam
                .FirstOrDefaultAsync(m => m.TeamID == id);
            if (ourTeam == null)
            {
                return NotFound();
            }

            return View(ourTeam);
        }

        // GET: OurTeam/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OurTeam/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeamID,MasterChef,SousChef,CrewMembers,Bartender,Cashier")] OurTeam ourTeam)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ourTeam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ourTeam);
        }

        // GET: OurTeam/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourTeam = await _context.OurTeam.FindAsync(id);
            if (ourTeam == null)
            {
                return NotFound();
            }
            return View(ourTeam);
        }

        // POST: OurTeam/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeamID,MasterChef,SousChef,CrewMembers,Bartender,Cashier")] OurTeam ourTeam)
        {
            if (id != ourTeam.TeamID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ourTeam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OurTeamExists(ourTeam.TeamID))
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
            return View(ourTeam);
        }

        // GET: OurTeam/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourTeam = await _context.OurTeam
                .FirstOrDefaultAsync(m => m.TeamID == id);
            if (ourTeam == null)
            {
                return NotFound();
            }

            return View(ourTeam);
        }

        // POST: OurTeam/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ourTeam = await _context.OurTeam.FindAsync(id);
            _context.OurTeam.Remove(ourTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OurTeamExists(int id)
        {
            return _context.OurTeam.Any(e => e.TeamID == id);
        }
    }
}
