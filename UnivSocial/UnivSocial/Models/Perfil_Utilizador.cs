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
    
    public partial class Perfil_Utilizador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Perfil_Utilizador()
        {
            this.Contactos = new HashSet<Contactos>();
        }
    
        public int id_Perfil { get; set; }
        public int id_user { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public Nullable<int> genero { get; set; }
        public System.DateTime dataNasc { get; set; }
        public Nullable<int> estado { get; set; }
        public string website { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contactos> Contactos { get; set; }
        public virtual Utilizadores Utilizadores { get; set; }
    }
}