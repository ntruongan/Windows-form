//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameGK
{
    using System;
    using System.Collections.Generic;
    
    public partial class CuonSach
    {
        public string MaSach { get; set; }
        public string MaCuon { get; set; }
        public string ViTri { get; set; }
    
        public virtual DAUSACH DAUSACH { get; set; }
        public virtual Muon Muon { get; set; }
    }
}
