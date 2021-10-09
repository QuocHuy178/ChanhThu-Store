﻿using ChanhThuStore.Models.BUS;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChanhThuStore.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index(int page=1 ,int pagesize = 1)
        {
            var db = ChanhThuStoreBUS.DanhSach().ToPagedList(page,pagesize);
            return View(db) ;
        }

        // GET: Shop/Details/5
        public ActionResult Details(String id)
        {
            var db = ChanhThuStoreBUS.ChiTiet(id);
            return View(db);
        }

        // GET: Shop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shop/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shop/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shop/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
