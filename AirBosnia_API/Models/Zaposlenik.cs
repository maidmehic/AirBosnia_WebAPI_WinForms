//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirBosnia_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zaposlenik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaposlenik()
        {
            this.KorisnickiNalog = new HashSet<KorisnickiNalog>();
            this.Let = new HashSet<Let>();
            this.PosadaLeta = new HashSet<PosadaLeta>();
            this.PosebnaPonuda = new HashSet<PosebnaPonuda>();
        }
    
        public int ZaposlenikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string BrojUgovora { get; set; }
        public string Spol { get; set; }
        public System.DateTime DatumRodenja { get; set; }
        public bool Aktivan { get; set; }
        public int TipZaposlenjaID { get; set; }
        public int GradID { get; set; }
    
        public virtual Grad Grad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KorisnickiNalog> KorisnickiNalog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Let> Let { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosadaLeta> PosadaLeta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosebnaPonuda> PosebnaPonuda { get; set; }
        public virtual TipZaposlenja TipZaposlenja { get; set; }
    }
}
