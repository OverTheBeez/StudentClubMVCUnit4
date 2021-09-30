using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentClubMVCUnit4.Models;

namespace StudentClubMVCUnit4.Controllers
{
    public class ClubsController : Controller
    {

        ClubList allClubs = new ClubList();
        // GET: Clubs
        public ActionResult Index()
        {
            return View("Index", allClubs.getAllClubs());
        }

        // GET: Clubs/Details/5
        public ActionResult Details(int id)
        {
            return View("Details", allClubs.getOneClub(id));
        }

        // GET: Clubs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clubs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {

            if (ModelState.IsValid) { 
            }
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clubs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clubs/Edit/5
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

        // GET: Clubs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clubs/Delete/5
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
