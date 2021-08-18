using QuanLyGiangVien.Dao;
using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiangVien.Controllers
{
    public class HocPhanController : Controller
    {
        // GET: HocPhan
        HocPhanDao hpD = new HocPhanDao();
        LoaiHocPhanDao lhpD = new LoaiHocPhanDao();
        public ActionResult Index(string msg)
        {
            var list = hpD.getAll();
            ViewBag.list = lhpD.getAll();
            ViewBag.Msg = msg;
            return View(list);
        }
        [HttpPost]
        public ActionResult add(FormCollection form)
        {
           
            var id_loaihocphan = Int32.Parse(form["loaihocphan"]);
            var tenhocphan = form["tenhocphan"];
            var tinchi = Int32.Parse(form["tinchi"]);
            hpD.add(tenhocphan,tinchi,id_loaihocphan);
            return RedirectToAction("Index", new { msg = "Thêm thành công" });
        }
        [HttpPost]
        public ActionResult edit(FormCollection form)
        {

            var id_loaihocphan = Int32.Parse(form["loaihocphan"]);
            var tenhocphan = form["tenhocphan"];
            var tinchi = Int32.Parse(form["tinchi"]);
            var id = Int32.Parse(form["id"]);
            hpD.edit(id,tenhocphan,tinchi,id_loaihocphan);
            return RedirectToAction("Index", new { msg = "Sửa thành công" });
        }
        [HttpPost]
        public ActionResult delete(FormCollection form)
        {
            int id = Int32.Parse(form["id"]);
            hpD.delete(id);
            return RedirectToAction("Index", new { msg = "Xóa thành công" });
        }
    }
}