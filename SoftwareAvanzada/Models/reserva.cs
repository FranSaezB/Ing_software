namespace SoftwareAvanzada
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("reserva")]
    public partial class reserva
    {
        public int Cod_tour { get; set; }

        [Required]
        [StringLength(1)]
        public string email_turista { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Cod_reserva { get; set; }

        public virtual turista turista { get; set; }

        public virtual tours tours { get; set; }
    }
}
