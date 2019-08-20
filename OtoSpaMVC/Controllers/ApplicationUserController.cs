using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OtoSpaMVC.Data;
using OtoSpaMVC.Models;
using OtoSpaMVC.Services;

namespace OtoSpaMVC.Controllers
{
    [Authorize(Policy = "MustBeAdmin")]
    public class ApplicationUserController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ApplicationUserController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: ApplicationUser
        public async Task<IActionResult> Index(string searchName,string searchEmail,string searchRole)
        {
            var users = from u in _context.Users select u;
            ViewData["NameFilter"] = searchName;
            ViewData["EmailFilter"] = searchEmail;
            ViewData["RoleFilter"] = searchRole;

            if (!String.IsNullOrEmpty(searchName))
            {
                users = users.Where(p => p.UserName.Contains(searchName));
            }
            if (!String.IsNullOrEmpty(searchEmail))
            {
                users = users.Where(p => p.Email.Contains(searchEmail));
            }
            if (!String.IsNullOrEmpty(searchRole))
            {
                users = users.Where(p =>
                GlobalFunctionality.GetUserRole(p, _context).Result.ToList().Exists(r =>
                 r.Name.Contains(searchRole)
                )).Select(p=>p);
            }
            return View(users.ToList());
        }

        // GET: ApplicationUser/Details/5
        public async Task<IActionResult> Details(string id)
        {

            var supplier = await _context.Users
                .SingleOrDefaultAsync(m => m.Id == id);
            if (supplier == null)
            {
                return NotFound();
            }

            return View(supplier);
        }

        // GET: ApplicationUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationUser/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("")] ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(applicationUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(applicationUser);
        }
        

        // GET: ApplicationUser/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.SingleOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: ApplicationUser/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string Id, string UserName,string Email)
        {
            var applicationUser= _context.Users.SingleOrDefault(u => u.Id == Id);
            if (Id != applicationUser.Id)
            {
                return NotFound();
            }

            if (!String.IsNullOrEmpty(UserName)&&!String.IsNullOrEmpty(Email))
            {
                try
                {
                    applicationUser.UserName = UserName;
                    applicationUser.NormalizedUserName = Email;
                    applicationUser.NormalizedEmail = Email;
                    applicationUser.SecurityStamp = Email;
                    applicationUser.Email = Email;
                    _context.Update(applicationUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(applicationUser.Id))
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
            return View(applicationUser);
        }

        // GET: ApplicationUser/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .SingleOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: ApplicationUser/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(m => m.Id == id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}