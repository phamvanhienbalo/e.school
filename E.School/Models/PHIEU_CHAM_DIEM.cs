//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E.School.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEU_CHAM_DIEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_CHAM_DIEM()
        {
            this.PCD_TIEUCHI = new HashSet<PCD_TIEUCHI>();
        }
    
        public int SoPCD { get; set; }
        public int SoPGDT { get; set; }
        public Nullable<System.DateTime> NgayCham { get; set; }
        public string VaitroGV { get; set; }
        public Nullable<double> DiemTong { get; set; }
        public string NhanXet { get; set; }
        public int MAGV { get; set; }
    
        public virtual GIANGVIEN GIANGVIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PCD_TIEUCHI> PCD_TIEUCHI { get; set; }
        public virtual PHIEUGIAODT PHIEUGIAODT { get; set; }
    }
}
