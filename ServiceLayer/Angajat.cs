//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Angajat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Angajat()
        {
            this.Subinventars = new HashSet<Subinventar>();
        }
    
        public int idAngajat { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public short idFacultate { get; set; }
    
        public virtual Facultate Facultate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subinventar> Subinventars { get; set; }
    }
}
