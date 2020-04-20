using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace superHeroManager.Controllers
{
    public class SuperHerosManagerController : Controller
    {
        // GET: SuperHerosManager
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperHerosManager/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperHerosManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHerosManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHerosManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperHerosManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHerosManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHerosManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}