using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OtoSpaMVC.Data;
using OtoSpaMVC.Models;

namespace OtoSpaMVC.Controllers
{
    
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Policy = "MustBeAdmin")]
        // GET: Contacts
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactUs.ToListAsync());
        }
        [Authorize(Policy = "MustBeAdmin")]
        // GET: Contacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactUs = await _context.ContactUs
                .SingleOrDefaultAsync(m => m.ID == id);
            if (contactUs == null)
            {
                return NotFound();
            }

            return View(contactUs);
        }

        // GET: Contacts/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Contacts/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ID,ContactHeader,Content,Phone,Email,ContactName")] ContactUs contactUs)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(contactUs);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(contactUs);
        //}

        // GET: Contacts/Edit/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactUs = await _context.ContactUs.SingleOrDefaultAsync(m => m.ID == id);
            if (contactUs == null)
            {
                return NotFound();
            }
            return View(contactUs);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ContactHeader,Content,Phone,Email,ContactName")] ContactUs contactUs)
        {
            if (id != contactUs.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactUs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactUsExists(contactUs.ID))
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
            return View(contactUs);
        }

        // GET: Contacts/Delete/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactUs = await _context.ContactUs
                .SingleOrDefaultAsync(m => m.ID == id);
            if (contactUs == null)
            {
                return NotFound();
            }

            return View(contactUs);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactUs = await _context.ContactUs.SingleOrDefaultAsync(m => m.ID == id);
            _context.ContactUs.Remove(contactUs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactUsExists(int id)
        {
            return _context.ContactUs.Any(e => e.ID == id);
        }





        //// GET: Contacts/ContactUsss
        //public IActionResult ContactUsss()
        //{
        //    return View();
        //}

        //// POST: Contacts/ContactUsss
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ContactUsss([Bind("ID,ContactHeader,Content,Phone,Email,ContactName")] ContactUs contactUs)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(contactUs);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(contactUs);
        //}

        // GET: Contacts/NewContactView
        public IActionResult NewContactView()
        {
            return View();
        }

        // POST: Contacts/NewContactView
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewContactView([Bind("ID,ContactHeader,Content,Phone,Email,ContactName,ContactDate")] ContactUs contactUs)
        {
            if (ModelState.IsValid)
            {
                contactUs.ContactDate = DateTime.Now;
                _context.Add(contactUs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactUs);
        }


    }
}
