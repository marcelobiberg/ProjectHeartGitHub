using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectHeart.Models
{
    public class Pessoa
    {
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string NOME { get; set; }

        [StringLength(15)]
        [Display(Name = "RG")]
        public string RG { get; set; }

        [Required(ErrorMessage = "Por favor, informe o E-mail!")]
        [Display(Name = "E-mail")]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Por favor, informe um E-mail válido.")]
        public string EMAIL { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime DATA_NASC { get; set; }

        [StringLength(15)]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [StringLength(50)]
        [Display(Name = "Bairro")]
        public string BAIRRO { get; set; }

        [StringLength(5)]
        [Display(Name = "Estado")]
        public string UF { get; set; }

        [StringLength(100)]
        [Display(Name = "Rua")]
        public string ENDERECO { get; set; }

        [StringLength(50)]
        [Display(Name = "Cidade")]
        public string CIDADE { get; set; }

        [StringLength(50)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [StringLength(5)]
        [Display(Name = "Sexo")]
        public string SEXO { get; set; }

        [Display(Name = "Naturalidade")]
        [StringLength(50)]
        public string NATURALIDADE { get; set; }

    }
}