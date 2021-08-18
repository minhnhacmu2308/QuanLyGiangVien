using QuanLyGiangVien.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiangVien.Controllers
{
    public class GiangVienController : Controller
    {
        // GET: GiangVien
        GiangVienDao gvD = new GiangVienDao();
        KhoaDao kD = new KhoaDao();
        HocViDao hvD = new HocViDao();
        HocHamDao hhD = new HocHamDao();
        LoaiGiangVienDao lgvD = new LoaiGiangVienDao();
        NoiDaoTaoDao ndt = new NoiDaoTaoDao();
        public ActionResult Index(string msg)
        {
            var list = gvD.getAll();
            ViewBag.listK = kD.getAll();
            ViewBag.listHv = hvD.getAll();
            ViewBag.listHh = hhD.getAll();
            ViewBag.listLgv = lgvD.getAll();
            ViewBag.listNdt = ndt.getAll();
            ViewBag.Msg = msg;
            ViewBag.year = getYear();
            return View(list);
        }
        [HttpPost]

        public List<int> getYear()
        {
            DateTime aDateTime = DateTime.Now;
            var list = new List<int>();
            for (int i = aDateTime.Year; i>= 1970 ; i--)
            {
                list.Add(i);
            }
            return list;
        }
        public ActionResult add(FormCollection form)
        {
          
            var hoten = form["hoten"];
            var gioitinh = Int32.Parse(form["gioitinh"]);
            var quequan = form["quequan"];
            var ngaybatdau = form["ngaybatdau"];
            var idHocHam = Int32.Parse(form["tenhocham"]);
            var idHocVi = Int32.Parse(form["tenhocvi"]); 
            var idKhoa = Int32.Parse(form["tenkhoa"]);
            var idLoaigv = Int32.Parse(form["loaigiangvien"]); 
            var idNoiDaotao = Int32.Parse(form["noidaotao"]);

            var namedathocvi = Int32.Parse(form["namhocvi"]);
            var namdathocham = Int32.Parse(form["namhocham"]);

            var ngaysinh = form["ngaysinh"];

            gvD.add(hoten, gioitinh, quequan, ngaybatdau, idHocHam, idHocVi, idKhoa, idLoaigv, idNoiDaotao, namedathocvi, namdathocham, ngaysinh);
            return RedirectToAction("Index", new { msg = "Thêm thành công" });
        }
        public ActionResult edit(FormCollection form)
        {

            var hoten = form["hoten"];
            var gioitinh = Int32.Parse(form["gioitinh"]);
            var quequan = form["quequan"];
            var ngaybatdau = form["ngaybatdau"];
            var idHocHam = Int32.Parse(form["tenhocham"]);
            var idHocVi = Int32.Parse(form["tenhocvi"]);
            var idKhoa = Int32.Parse(form["tenkhoa"]);
            var idLoaigv = Int32.Parse(form["loaigiangvien"]);
            var idNoiDaotao = Int32.Parse(form["noidaotao"]);
            int id = Int32.Parse(form["id"]);
            var namedathocvi = Int32.Parse(form["namhocvi"]);
            var namdathocham = Int32.Parse(form["namhocham"]);

            var ngaysinh = form["ngaysinh"];

            gvD.edit(id,hoten, gioitinh, quequan, ngaybatdau, idHocHam, idHocVi, idKhoa, idLoaigv, idNoiDaotao, namedathocvi, namdathocham, ngaysinh);
            return RedirectToAction("Index", new { msg = "Sửa thành công" });
        }
        public ActionResult delete(FormCollection form)
        {
            int id = Int32.Parse(form["id"]);
            gvD.delete(id);
            return RedirectToAction("Index", new { msg = "Xóa thành công" });
        }
    }
}