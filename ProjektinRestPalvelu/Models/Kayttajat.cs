//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektinRestPalvelu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kayttajat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kayttajat()
        {
            this.Arvostelut = new HashSet<Arvostelut>();
        }
    
        public int kayttaja_id { get; set; }
        public string nick { get; set; }
        public string etunimi { get; set; }
        public string sukunimi { get; set; }
        public string salasana { get; set; }
        public byte[] kuva { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arvostelut> Arvostelut { get; set; }
    }
}
