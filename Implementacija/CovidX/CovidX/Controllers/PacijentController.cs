using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Controllers
{
    public class PacijentController : Controller
    {
        // GET: PacijentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PacijentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PacijentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacijentController/Create
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

        // GET: PacijentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PacijentController/Edit/5
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

        // GET: PacijentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PacijentController/Delete/5
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
