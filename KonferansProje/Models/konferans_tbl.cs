//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KonferansProje.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class konferans_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public konferans_tbl()
        {
            this.katilimci_tbl = new HashSet<katilimci_tbl>();
        }
    
        public int id { get; set; }
        public string konferansAdi { get; set; }
        public string içeriktext { get; set; }
        public Nullable<System.DateTime> zamani { get; set; }
        public string konusmaciAdi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<katilimci_tbl> katilimci_tbl { get; set; }
        public virtual konferans_tbl konferans_tbl1 { get; set; }
        public virtual konferans_tbl konferans_tbl2 { get; set; }
    }
}
