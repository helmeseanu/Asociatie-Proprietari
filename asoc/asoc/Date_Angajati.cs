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
    
    public partial class Date_Angajati
    {
        public int index { get; set; }
        public int IdAngajat { get; set; }
        public string CNP { get; set; }
        public System.DateTime Data_Angajare { get; set; }
        public Nullable<int> Vechime { get; set; }
        public string Numar_telefon { get; set; }
        public string Localitate { get; set; }
        public string Strada { get; set; }
        public string Numar { get; set; }
        public string Bloc { get; set; }
        public string Scara { get; set; }
        public string Etaj { get; set; }
        public string Apartament { get; set; }
    
        public virtual Angajati Angajati { get; set; }
    }
}