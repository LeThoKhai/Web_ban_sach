//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_ban_sach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DONDATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONDATHANG()
        {
            this.CHITIETDONHANG = new HashSet<CHITIETDONHANG>();
        }
    
        public string MaDonHang { get; set; }
        public bool Dathanhtoan { get; set; }
        public string Tinhtranggiaohang { get; set; }
        public System.DateTime Ngaydat { get; set; }
        public System.DateTime Ngaygiao { get; set; }
        public string MaKH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANG { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
