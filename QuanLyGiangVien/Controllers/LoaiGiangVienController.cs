using QuanLyGiangVien.Dao;
using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiangVien.Controllers
{
    public class LoaiGiangVienController : Controller
    {
        // GET: LoaiGiangVien
        LoaiGiangVienDao ldvD = new LoaiGiangVienDao();
        public ActionResult Index(string msg)
        {
            var list = ldvD.getAll();
            ViewBag.Msg = msg;
            return View(list);
        }
        [HttpPost]
        public ActionResult add(FormCollection form)
        {
            LoaiGiangVien lgv = new LoaiGiangVien();
            lgv.tenloaigiangvien = form["loaigiangvien"];
            ldvD.add(lgv);
            return RedirectToAction("Index" ,new { msg = "Thêm thành công"});
        }
        [HttpPost]
        public ActionResult edit(FormCollection form)
        {
            LoaiGiangVien lgv = new LoaiGiangVien();
            lgv.tenloaigiangvien = form["loaigiangvien"];
            lgv.id = Int32.Parse(form["id"]);
            ldvD.update(lgv);
            return RedirectToAction("Index",new { msg = "Sửa thành công" });
        }
        [HttpPost]
        public ActionResult delete(FormCollection form)
        {
            int id = Int32.Parse(form["id"]);
            ldvD.delete(id);
            return RedirectToAction("Index", new { msg = "Xóa thành công" });
        }
    }
}