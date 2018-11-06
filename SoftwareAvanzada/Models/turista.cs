namespace SoftwareAvanzada
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("turista")]
    public partial class turista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public turista()
        {
            reserva = new HashSet<reserva>();
        }

        [Key]
        [StringLength(1)]
        public string email_turista { get; set; }

        [Column(TypeName = "text")]
        public string nombre { get; set; }

        [Column(TypeName = "text")]
        public string apellido { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? telefono { get; set; }

        [Column(TypeName = "text")]
        public string password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reserva> reserva { get; set; }
    }
}
