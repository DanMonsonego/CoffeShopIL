﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeShopIL.Models;
using System.Data;

namespace CoffeShopIL.Controllers
{
    public class CategoryController : Controller
    {
        CoffeeShopDbEntities db = new CoffeeShopDbEntities();

        #region showing categories for admin

        public ActionResult Index()
        {
            var query = db.Categories.ToList();

            return View(query);
        }

        #endregion


        #region add categories

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categories c)
        {
            if (ModelState.IsValid)
            {
                Categories cat = new Categories();
                cat.Name = c.Name;
                db.Categories.Add(cat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["msg"] = "Not Inserted Category";
            }
            return View();
        }

        #endregion


        #region edit category

        public ActionResult Edit(int id)
        {
            var query = db.Categories.SingleOrDefault(m => m.CatId == id);
            return View(query);
        }

        [HttpPost]
        public ActionResult Edit(Categories c)
        {
            try
            {
               
                db.Entry(c).State = (System.Data.Entity.EntityState)EntityState.Modified;
                db.SaveChanges();
               
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["msg"] = ex;
            }
            return RedirectToAction("Index");
        }

        #endregion

        #region delete category

        public ActionResult Delete(int id)
        {
            var query = db.Categories.SingleOrDefault(m => m.CatId == id);
            db.Categories.Remove(query);
            db.SaveChanges();
           return RedirectToAction("Index");
        }

      

        #endregion


    }
}