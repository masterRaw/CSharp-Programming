using Microsoft.AspNetCore.Mvc;
using Phone_Directory.Data;
using Phone_Directory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phone_Directory.Controllers
{
    public class DirectoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public DirectoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Directory> objlist = _db.Directory;
            return View(objlist);
        }

        //GET CREATE
        public IActionResult Create()
        {

            return View();
        }

        //POST CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Directory obj)
        {
            if (ModelState.IsValid)
            {
                _db.Directory.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }

        //GET EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Directory.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Directory obj)
        {
            if (ModelState.IsValid)
            {
                _db.Directory.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }

        //GET DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Directory.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteP(Directory obj)
        {

            if (obj == null)
            {
                return NotFound();
            }
            _db.Directory.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
