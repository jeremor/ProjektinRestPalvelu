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
    
    public partial class Arvostelut
    {
        public int arvostelu_id { get; set; }
        public int juoma_id { get; set; }
        public int kayttaja_id { get; set; }
        public string arvosteluteksti { get; set; }
        public int pisteet { get; set; }
    
        public virtual Juomat Juomat { get; set; }
        public virtual Kayttajat Kayttajat { get; set; }
    }
}
