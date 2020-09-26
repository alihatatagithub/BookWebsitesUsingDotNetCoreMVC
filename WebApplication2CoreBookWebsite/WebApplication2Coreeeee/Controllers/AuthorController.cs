using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2Coreeeee.Models;
using WebApplication2Coreeeee.Models.Repositories;

namespace WebApplication2Coreeeee.Controllers
{
    public class AuthorController : Controller
    {
        public IBookStoreRepository<Author> AuthorRepo;

        public AuthorController(IBookStoreRepository<Author> authorRepo)
        {
            AuthorRepo = authorRepo;
        }
        // GET: AuthorController
        public ActionResult Index()
        {
            return View(AuthorRepo.List());
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            var author = AuthorRepo.Find(id);
            return View(author);
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author author)
        {
            try
            {
                AuthorRepo.Add(author);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            var auther = AuthorRepo.Find(id);
            return View(auther);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Author author)
        {
            try
            {
                AuthorRepo.Update(id, author);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            var author = AuthorRepo.Find(id);
            return View(author);
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Author auther)
        {
            try
            {
                AuthorRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
