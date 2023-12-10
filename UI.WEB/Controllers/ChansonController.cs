using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace UI.WEB.Controllers
{


   
    public class ChansonController : Controller
    {
        IChansonService sf;
        public ChansonController(IChansonService sf)
        {
            this.sf = sf;
        }



        // GET: ChansonController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChansonController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChansonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChansonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Chanson collection)
        {
            try
            {
                sf.Add(collection);
                sf.Commit();
                return RedirectToAction(nameof(Index));
            }

            catch
            {
                return View();
            }

        }

        // GET: ChansonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChansonController/Edit/5
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

        // GET: ChansonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChansonController/Delete/5
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
