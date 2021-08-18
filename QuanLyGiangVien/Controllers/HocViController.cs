using QuanLyGiangVien.Dao;
using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiangVien.Controllers
{
    public class HocViController : Controller
    {
        HocViDao hvD = new HocViDao();
        // GET: HocVi
        public ActionResult Index(string msg)
        {
            var list = hvD.getAll();
            ViewBag.Msg = msg;
            return View(list);
        }
        public ActionResult add(FormCollection form)
        {
            HocVi lgv = new HocVi();
            lgv.tenhocvi = form["tenhocvi"];
            hvD.add(lgv);
            return RedirectToAction("Index", new { msg = "Thêm thành công" });
        }
        [HttpPost]
        public ActionResult edit(FormCollection form)
        {
            HocVi lgv = new HocVi();
            lgv.tenhocvi = form["tenhocvi"];
            lgv.id = Int32.Parse(form["id"]);
            hvD.edit(lgv);
            return RedirectToAction("Index", new { msg = "Sửa thành công" });
        }
        [HttpPost]
        public ActionResult delete(FormCollection form)
        {
            int id = Int32.Parse(form["id"]);
            hvD.delete(id);
            return RedirectToAction("Index", new { msg = "Xóa thành công" });
        }
    }
}