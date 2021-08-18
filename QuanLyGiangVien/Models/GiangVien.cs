using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGiangVien.Models
{
    public class GiangVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(255)]
        [Required]
        public string hoten { get; set; }

        public DateTime ngaysinh { get; set; }

        public int gioitinh { get; set; }

        [StringLength(255)]
        public string quequan { get; set; }

        public DateTime ngaybatdau { get; set; }

        public int namdathocvi { get; set; }

        public int namdathocham { get; set; }
      

        public virtual HocVi HocVi { get; set; }

        public virtual HocHam HocHam {get;set;}


        public virtual Khoa Khoa { get; set; }

        public virtual NoiDaoTao NoiDaoTao { get; set; }

        public virtual LoaiGiangVien LoaiGiaoVien { get; set; }

        public virtual ICollection<GiangDay> GiangDays { get; set; }
    }
}