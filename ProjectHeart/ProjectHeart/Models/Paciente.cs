namespace ProjectHeart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Paciente")]
    public partial class Paciente
    {
        [Key]
        [Column(Order = 0)]
        public int ID_PACIENTE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CONVENIO { get; set; }

        [StringLength(50)]
        public string NOME_PACIENTE { get; set; }

        [StringLength(20)]
        public string RG { get; set; }

        [StringLength(50)]
        public string RESPONSAVEL { get; set; }

        [StringLength(50)]
        public string ESTADO { get; set; }

        [StringLength(50)]
        public string ENDERECO { get; set; }

        [StringLength(50)]
        public string NR_CARTEIRA { get; set; }

        [StringLength(50)]
        public string CIDADE { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        public virtual Convenio Convenio { get; set; }
    }
}
