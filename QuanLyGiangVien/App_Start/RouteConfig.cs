using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QuanLyGiangVien
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "loai giang vien",
               url: "loaigiangvien/getall",
               defaults: new { controller = "LoaiGiangVien", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "loai hoc phan",
              url: "loaihocphan/getall",
              defaults: new { controller = "LoaiHocPhan", action = "Index", id = UrlParameter.Optional }
          );
            routes.MapRoute(
            name: "khoa",
            url: "khoa/getall",
            defaults: new { controller = "Khoa", action = "Index", id = UrlParameter.Optional }
        );
            routes.MapRoute(
            name: "hoc ham",
            url: "hocham/getall",
            defaults: new { controller = "HocHam", action = "Index", id = UrlParameter.Optional }
        );
            routes.MapRoute(
           name: "hoc vi",
           url: "hocvi/getall",
           defaults: new { controller = "HocVi", action = "Index", id = UrlParameter.Optional }
       );
            routes.MapRoute(
          name: "hoc phan",
          url: "hocphan/getall",
          defaults: new { controller = "HocPhan", action = "Index", id = UrlParameter.Optional }
      );
            routes.MapRoute(
         name: "noi dao tao",
         url: "noidaotao/getall",
         defaults: new { controller = "NoiDaoTao", action = "Index", id = UrlParameter.Optional }
     );
            routes.MapRoute(
        name: "giang vien",
        url: "giangvien/getall",
        defaults: new { controller = "GiangVien", action = "Index", id = UrlParameter.Optional }
    );
            routes.MapRoute(
        name: "giang day",
        url: "giangday/getall",
        defaults: new { controller = "GiangDay", action = "Index", id = UrlParameter.Optional }
    );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
