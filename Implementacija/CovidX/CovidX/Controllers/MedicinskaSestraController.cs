using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Controllers
{
    public class MedicinskaSestraController : Controller
    {
        // GET: MedicinskaSestraController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MedicinskaSestraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicinskaSestraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicinskaSestraController/Create
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

        // GET: MedicinskaSestraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicinskaSestraController/Edit/5
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

        // GET: MedicinskaSestraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicinskaSestraController/Delete/5
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
