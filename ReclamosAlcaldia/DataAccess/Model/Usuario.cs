//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.LogReclamo = new HashSet<LogReclamo>();
        }
    
        public string nombreDeUsuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string contraseña { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string tipo { get; set; }
    
        public virtual Ciudadano Ciudadano { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogReclamo> LogReclamo { get; set; }
    }
}