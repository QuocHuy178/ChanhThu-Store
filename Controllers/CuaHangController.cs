using ChanhThuStore.Models.BUS;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChanhThuStore.Controllers
{
    public class CuaHangController : Controller
    {
        // GET: CuaHang
        public ActionResult Index(int page=1 ,int pagesize = 1)
        {
            var db = ChanhThuStoreBUS.DanhSach().ToPagedList(page,pagesize);
            return View(db) ;
        }

        // GET: CuaHang/Details/5
        public ActionResult Details(String id)
        {
            var db = ChanhThuStoreBUS.ChiTiet(id);
            return View(db);
        }

        // GET: CuaHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuaHang/Create
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

        // GET: CuaHang/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuaHang/Edit/5
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

        // GET: CuaHang/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuaHang/Delete/5
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
