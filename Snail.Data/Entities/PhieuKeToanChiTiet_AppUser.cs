using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Snail.Data.Entities
{
    public class PhieuKeToanChiTiet_AppUser : BaseEntity
    {
        public int PhieuKeToanChiTietId { set; get; }
        public PhieuKeToanChiTiet PhieuKeToanChiTiet { get; set; }        
        public Guid? AppUserId { set; get; }
        public AppUser AppUser { get; set; }
    }
}