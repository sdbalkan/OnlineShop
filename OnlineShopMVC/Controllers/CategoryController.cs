using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopEF.DAL;

namespace OnlineShopMVC.Controllers
{
    public class CategoryController : Controller
    {
        UnitOfWorkEF _uow = new UnitOfWorkEF();

        // GET: Category
        public ActionResult Index()
        {
            List<Category> categories = _uow.Repository<Category>().List();
            return View(categories);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            Category category = _uow.Repository<Category>().GetById(id);
            return View(category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                // TODO: Add insert logic here               
                _uow.Repository<Category>().Add(category);
                _uow.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            Category category = _uow.Repository<Category>().GetById(id);
            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                // TODO: Add update logic here
                _uow.Repository<Category>().Update(category);
                _uow.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            Category category = _uow.Repository<Category>().GetById(id);
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Category category)
        {
            try
            {
                // TODO: Add delete logic here
                _uow.Repository<Category>().Delete(id);
                _uow.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
