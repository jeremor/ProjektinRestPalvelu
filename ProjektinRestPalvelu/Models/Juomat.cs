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
    
    public partial class Juomat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Juomat()
        {
            this.Arvostelut = new HashSet<Arvostelut>();
        }
    
        public int juoma_id { get; set; }
        public string kategoria { get; set; }
        public string nimi { get; set; }
        public string valmistaja { get; set; }
        public Nullable<double> hinta { get; set; }
        public string valmistusmaa { get; set; }
        public int valmistusvuosi { get; set; }
        public string kuvaus { get; set; }
        public byte[] kuva { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arvostelut> Arvostelut { get; set; }
    }
}
