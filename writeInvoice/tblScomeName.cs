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
    
    public partial class tblScomeName
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblScomeName()
        {
            this.tblBody = new HashSet<tblBody>();
            this.tblHeader = new HashSet<tblHeader>();
        }
    
        public short No { get; set; }
        public string Name { get; set; }
        public Nullable<short> DocumentNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBody> tblBody { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHeader> tblHeader { get; set; }
        public virtual tblDocument tblDocument { get; set; }
    }
}
