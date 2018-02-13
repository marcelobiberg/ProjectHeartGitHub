namespace ProjectHeart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Convenio")]
    public class Convenio 
    {
        [Key]
        public int ID_CONVENIO { get; set; }

        [StringLength(50)]
        [Display(Name = "Identifica��o conv�nio")]
        public string NR_CONVENIO { get; set; }

        [StringLength(100)]
        [Display(Name = "Conv�nio")]
        public string NOME_CONVENIO { get; set; }

        [Display(Name = "Validade")]
        public DateTime? VALIDADE { get; set; }

    }
}
