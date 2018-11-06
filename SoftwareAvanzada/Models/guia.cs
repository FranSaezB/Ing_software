namespace SoftwareAvanzada
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guia")]
    public partial class guia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public guia()
        {
            tours = new HashSet<tours>();
        }

        [Key]
        [StringLength(1)]
        public string email_guia { get; set; }

        [Column(TypeName = "text")]
        public string password_guia { get; set; }

        [Column(TypeName = "text")]
        public string sexo { get; set; }

        [Column(TypeName = "text")]
        public string nombre { get; set; }

        [Column(TypeName = "text")]
        public string apellido { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? telefono { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tours> tours { get; set; }
    }
}
