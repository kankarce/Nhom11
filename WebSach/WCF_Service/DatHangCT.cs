//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class DatHangCT
    {
        public int DatHangID { get; set; }
        public int SachID { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<double> ThanhTien { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual DatHang DatHang { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
