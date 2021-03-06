using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGiangVien.Models
{
    public class LoaiGiangVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(255)]
        [Required]
        public string tenloaigiangvien { get; set; }
        public virtual ICollection<GiangVien> GiangViens { get; set; }
    }
}