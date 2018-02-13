namespace ProjectHeart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Reflection;

    [Table("Paciente")]
    public class Paciente : Pessoa
    {

        [Key]
        public int ID_PACIENTE { get; set; }

        [Key]
        public int ID_CONVENIO { get; set; }

        [StringLength(5)]
        [Display(Name = "Staus")]
        public string STATUS { get; set; }

        [StringLength(50)]
        [Display(Name = "Nro Carteira")]
        public string NR_CARTEIRA { get; set; }

        [StringLength(50)]
        [Display(Name = "Responsável")]
        public string RESPONSAVEL { get; set; }

        [StringLength(100)]
        [Display(Name = "Observação")]
        public string COMPLEMENTAR { get; set; }

        [StringLength(50)]
        [Display(Name = "Profissão")]
        public string PROFISSAO { get; set; }

        [StringLength(15)]
        [Display(Name = "Celular")]
        public string CELULAR { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(15)]
        public string TELEFONE { get; set; }

        [Display(Name = "Trabalho")]
        [StringLength(15)]
        public string TELEFONE2 { get; set; }

        [StringLength(5)]
        [Display(Name = "SMS")]
        public string SMS { get; set; }

    }
}
