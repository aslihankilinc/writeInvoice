//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace writeInvoice
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBody
    {
        public short No { get; set; }
        public decimal Left { get; set; }
        public decimal Top { get; set; }
        public short ScomeNo { get; set; }
    
        public virtual tblScomeName tblScomeName { get; set; }
    }
}
