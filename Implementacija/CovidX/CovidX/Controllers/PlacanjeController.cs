using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Controllers
{
    public class PlacanjeController : Controller
    {
        // GET: PlacanjeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PlacanjeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlacanjeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlacanjeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlacanjeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlacanjeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlacanjeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlacanjeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
