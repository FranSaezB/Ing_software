namespace SoftwareAvanzada
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tours()
        {
            reserva = new HashSet<reserva>();
        }

        [Column(TypeName = "text")]
        public string ciudad { get; set; }

        [Column(TypeName = "text")]
        public string idioma { get; set; }

        public int? duracion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? valoracion { get; set; }

        [Column(TypeName = "text")]
        public string descripcion_tour { get; set; }

        [Column(TypeName = "text")]
        public string descripcion_guia { get; set; }

        [Column(TypeName = "text")]
        public string punto_encuentro { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cod_tour { get; set; }

        [Required]
        [StringLength(1)]
        public string email_guia { get; set; }

        public virtual guia guia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reserva> reserva { get; set; }
    }
}
