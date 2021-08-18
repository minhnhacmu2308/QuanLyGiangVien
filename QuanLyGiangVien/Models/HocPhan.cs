using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGiangVien.Models
{
    public class HocPhan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(255)]
        [Required]
        public string tenhocphan { get; set; }

        public int tinchi { get; set; }

        public virtual LoaiHocPhan LoaiHocPhan { get; set; }
    }
}