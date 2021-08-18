using QuanLyGiangVien.Dao;
using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiangVien.Controllers
{
    public class KhoaController : Controller
    {
        // GET: Khoa
        KhoaDao kD = new KhoaDao();
        public ActionResult Index(string msg)
        {
            var list = kD.getAll();
            ViewBag.Msg = msg; 
            return View(list);
        }
        public ActionResult add(FormCollection form)
        {
            Khoa lgv = new Khoa();
            lgv.tenkhoa = form["tenkhoa"];
            kD.add(lgv);
            return RedirectToAction("Index", new { msg = "Thêm thành công" });
        }
        [HttpPost]
        public ActionResult edit(FormCollection form)
        {
            Khoa lgv = new Khoa();
            lgv.tenkhoa = form["tenkhoa"];
            lgv.id = Int32.Parse(form["id"]);
            kD.edit(lgv);
            return RedirectToAction("Index", new { msg = "Sửa thành công" });
        }
        [HttpPost]
        public ActionResult delete(FormCollection form)
        {
            int id = Int32.Parse(form["id"]);
            kD.delete(id);
            return RedirectToAction("Index", new { msg = "Xóa thành công" });
        }
    }
}