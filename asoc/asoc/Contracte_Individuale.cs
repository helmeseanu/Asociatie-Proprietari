//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asoc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contracte_Individuale
    {
        public int Index { get; set; }
        public int IdApartament { get; set; }
        public string Serviciu { get; set; }
        public System.DateTime Data { get; set; }
    
        public virtual Apartamente Apartamente { get; set; }
    }
}
