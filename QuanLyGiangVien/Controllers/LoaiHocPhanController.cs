using QuanLyGiangVien.Dao;
using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiangVien.Controllers
{
    public class LoaiHocPhanController : Controller
    {
        // GET: LoaiHocPhan
        LoaiHocPhanDao lhpD = new LoaiHocPhanDao();
        public ActionResult Index(string msg)
        {
            var list = lhpD.getAll();
            ViewBag.Msg = msg;
            return View(list);
        }
        public ActionResult add(FormCollection form)
        {
            LoaiHocPhan lgv = new LoaiHocPhan();
            lgv.tenloaihocphan = form["loaihocphan"];
            lhpD.add(lgv);
            return RedirectToAction("Index", new { msg = "Thêm thành công" });
        }
        [HttpPost]
        public ActionResult edit(FormCollection form)
        {
            LoaiHocPhan lgv = new LoaiHocPhan();
            lgv.tenloaihocphan = form["loaihocphan"];
            lgv.id = Int32.Parse(form["id"]);
            lhpD.edit(lgv);
            return RedirectToAction("Index", new { msg = "Sửa thành công" });
        }
        [HttpPost]
        public ActionResult delete(FormCollection form)
        {
            int id = Int32.Parse(form["id"]);
            lhpD.delete(id);
            return RedirectToAction("Index", new { msg = "Xóa thành công" });
        }
    }
}