using QuanLyGiangVien.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiangVien.Controllers
{
    public class GiangDayController : Controller
    {
        // GET: GiangDay
        GiangDayDao gdD = new GiangDayDao();
        GiangVienDao gvD = new GiangVienDao();
        HocPhanDao hpD = new HocPhanDao();
        public ActionResult Index(string msg)
        {
            var list = gdD.getAll();
            ViewBag.listHp = hpD.getAll();
            ViewBag.listGv = gvD.getAll();
            ViewBag.Msg = msg;
            return View(list);
        }
        [HttpPost]
        public ActionResult add(FormCollection form)
        {

            var id_hocphan = Int32.Parse(form["tenhocphan"]);
            var id_giangvien = Int32.Parse(form["tengiangvien"]);
            var ngaybatdau = form["ngaybatdau"];
            var ngayketthuc = form["ngayketthuc"];
            gdD.add(id_hocphan, id_giangvien, ngaybatdau, ngayketthuc);
            return RedirectToAction("Index", new { msg = "Thêm thành công" });
        }
        [HttpPost]
        public ActionResult edit(FormCollection form)
        {

            var id_hocphan = Int32.Parse(form["tenhocphan"]);
            var id_giangvien = Int32.Parse(form["tengiangvien"]);
            var ngaybatdau = form["ngaybatdau"];
            var ngayketthuc = form["ngayketthuc"];
            var id = Int32.Parse(form["id"]);
            gdD.edit(id, id_hocphan, id_giangvien, ngaybatdau, ngayketthuc);
            return RedirectToAction("Index", new { msg = "Sửa thành công" });
        }
        [HttpPost]
        public ActionResult delete(FormCollection form)
        {
            int id = Int32.Parse(form["id"]);
            gdD.delete(id);
            return RedirectToAction("Index", new { msg = "Xóa thành công" });
        }
    }
}