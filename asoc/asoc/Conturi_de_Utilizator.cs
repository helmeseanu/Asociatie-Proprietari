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
    
    public partial class Conturi_de_Utilizator
    {
        public int Index { get; set; }
        public string Username { get; set; }
        public string Parola { get; set; }
        public int IDMembru { get; set; }
        public string TipCont { get; set; }
    
        public virtual Membri_Asociatie Membri_Asociatie { get; set; }
    }
}
