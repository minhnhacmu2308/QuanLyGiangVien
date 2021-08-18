using QuanLyGiangVien.Dao;
using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiangVien.Controllers
{
    public class HocHamController : Controller
    {
        // GET: HocHam
        HocHamDao hhD = new HocHamDao();
        public ActionResult Index(string msg)
        {
            var list = hhD.getAll();
            ViewBag.Msg = msg;
            return View(list);
        }
        public ActionResult add(FormCollection form)
        {
            HocHam lgv = new HocHam();
            lgv.tenhocham = form["tenhocham"];
            hhD.add(lgv);
            return RedirectToAction("Index", new { msg = "Thêm thành công" });
        }
        [HttpPost]
        public ActionResult edit(FormCollection form)
        {
            HocHam lgv = new HocHam();
            lgv.tenhocham = form["tenhocham"];
            lgv.id = Int32.Parse(form["id"]);
            hhD.edit(lgv);
            return RedirectToAction("Index", new { msg = "Sửa thành công" });
        }
        [HttpPost]
        public ActionResult delete(FormCollection form)
        {
            int id = Int32.Parse(form["id"]);
            hhD.delete(id);
            return RedirectToAction("Index", new { msg = "Xóa thành công" });
        }
    }
}