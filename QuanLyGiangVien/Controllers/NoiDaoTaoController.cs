using QuanLyGiangVien.Dao;
using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiangVien.Controllers
{
    public class NoiDaoTaoController : Controller
    {
        NoiDaoTaoDao ndtD = new NoiDaoTaoDao();
        // GET: NoiDaoTao
        public ActionResult Index()
        {
            var list = ndtD.getAll();
            return View(list);
        }
        [HttpPost]
        public ActionResult add(FormCollection form)
        {
            NoiDaoTao lgv = new NoiDaoTao();
            lgv.tentruong = form["tentruong"];
            lgv.thanhpho = form["thanhpho"];
            lgv.quocgia = form["quocgia"];
            ndtD.add(lgv);
            return RedirectToAction("Index", new { msg = "Thêm thành công" });
        }
        [HttpPost]
        public ActionResult edit(FormCollection form)
        {
            NoiDaoTao lgv = new NoiDaoTao();
            lgv.tentruong = form["tentruong"];
            lgv.thanhpho = form["thanhpho"];
            lgv.quocgia = form["quocgia"];
            lgv.id = Int32.Parse(form["id"]);
            ndtD.edit(lgv);
            return RedirectToAction("Index", new { msg = "Sửa thành công" });
        }
        [HttpPost]
        public ActionResult delete(FormCollection form)
        {
            int id = Int32.Parse(form["id"]);
            ndtD.delete(id);
            return RedirectToAction("Index", new { msg = "Xóa thành công" });
        }
    }
}