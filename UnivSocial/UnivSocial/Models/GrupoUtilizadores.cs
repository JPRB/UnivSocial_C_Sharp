//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnivSocial.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GrupoUtilizadores
    {
        public int id_grupo { get; set; }
        public int id_user { get; set; }
        public int estado { get; set; }
        public int tipo { get; set; }
        public Nullable<System.DateTime> data { get; set; }
    
        public virtual Grupos Grupos { get; set; }
        public virtual Utilizadores Utilizadores { get; set; }
    }
}