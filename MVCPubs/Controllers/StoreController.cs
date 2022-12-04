using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCPubs.Data;
using MVCPubs.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCPubs.Controllers
{
    public class StoreController : Controller
    {
        private readonly PubsContext _context;

        public StoreController(PubsContext context)
        {
            _context = context;
        }

        // GET: /Store 
        public IActionResult Index()
        {
            return View(_context.Stores.ToList());
        }

        // GET: /Store/Create
        public IActionResult Create()
        {
            Store store = new Store();
            return View("Create", store);
        }

        // POST: /Store/Create
        [HttpPost]
        public IActionResult Create(Store store)
        {
            _context.Add(store);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //GET: /Store/Delete/1
        public IActionResult Delete(string id)
        {
            var store = _context.Stores.SingleOrDefault(m => m.StorId == id);
            if (store != null)
            {
                _context.Stores.Remove(store);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        //GET: /Store/Edit/1
        [HttpGet]
        public ActionResult Edit(string id)
        {

            Store store = _context.Stores.Find(id);

            return View("Edit", store);

        }

        [HttpPost]
        public ActionResult Edit(Store store)
        {

            if (ModelState.IsValid)
            {

                _context.Entry(store).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(store);

        }
     
    }
}
