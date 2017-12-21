namespace ProjectHeart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Convenio")]
    public partial class Convenio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Convenio()
        {
            Pacientes = new HashSet<Paciente>();
        }

        [Key]
        public int ID_CONVENIO { get; set; }

        [StringLength(50)]
        public string NR_CONVENIO { get; set; }

        [StringLength(5)]
        public string NOME_CONVENIO { get; set; }

        public DateTime? VALIDADE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
