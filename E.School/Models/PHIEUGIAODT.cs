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
    
    public partial class PHIEUGIAODT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUGIAODT()
        {
            this.PHIEU_CHAM_DIEM = new HashSet<PHIEU_CHAM_DIEM>();
            this.PHIEUTHEODOIs = new HashSet<PHIEUTHEODOI>();
        }
    
        public int SoPGDT { get; set; }
        public Nullable<System.DateTime> Ngaygiao { get; set; }
        public Nullable<System.DateTime> Hannop { get; set; }
        public int MASV { get; set; }
        public int MADT { get; set; }
        public int MAGV { get; set; }
    
        public virtual DETAI DETAI { get; set; }
        public virtual GIANGVIEN GIANGVIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_CHAM_DIEM> PHIEU_CHAM_DIEM { get; set; }
        public virtual SINHVIEN SINHVIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHEODOI> PHIEUTHEODOIs { get; set; }
    }
}
