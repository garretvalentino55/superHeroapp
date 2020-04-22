using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using superHeros.Data;
using superHeros.Models;

namespace superHeros.Controllers
{
    public class SuperHerosController : Controller
    {
        private ApplicationDbContext db;
        public SuperHerosController(ApplicationDbContext dbcontext)
        {
            db = dbcontext;
        }
        // GET: SuperHeros
        public IActionResult Index()
        {
            var superHeros = db.SuperHero.ToList();
            return View(superHeros);
        }

        // GET: SuperHeros/Details/5
        public IActionResult Details(int id)
        {
            try
            {
                var superHeros = db.SuperHero.Where(s => s.superHeroId == id).FirstOrDefault();
                return View(superHeros);
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: SuperHeros/Create
        public IActionResult Create()
        {
            //new superhero object
            return View();
        }

        // POST: SuperHeros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SuperHeros SuperHero)
        {
            try
            {
                // TODO: Add insert logic here
                var superHeros = db.SuperHero.Add(SuperHero);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeros/Edit/5
        public IActionResult Edit(int id)
        {
            var superHero = db.SuperHero.Where(j => j.superHeroId == id).FirstOrDefault();
            return View(superHero);
        }

        // POST: SuperHeros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, SuperHeros superHero)
        {
            try
            {
                // TODO: Add update logic here
                var superHeros = db.SuperHero.Where(k => k.superHeroId == id).FirstOrDefault();
                superHeros.alterEgo = superHero.alterEgo;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeros/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeros/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, SuperHeros superHero)
        {
            try
            {
                // TODO: Add delete logic here
                var superHeros = db.SuperHero.Where(s => s.superHeroId == id).FirstOrDefault();
                db.Remove(superHeros);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}