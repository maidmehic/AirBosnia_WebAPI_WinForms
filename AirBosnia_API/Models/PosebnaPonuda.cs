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
    
    public partial class PosebnaPonuda
    {
        public int PosebnaPonudaID { get; set; }
        public int LetPolazakID { get; set; }
        public int LetDolazakID { get; set; }
        public int ZaposlenikID { get; set; }
        public double CijenaBezKarte { get; set; }
        public string BrojDana { get; set; }
        public string Smjestaj { get; set; }
        public string Napomena { get; set; }
    
        public virtual Let Let { get; set; }
        public virtual Let Let1 { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}