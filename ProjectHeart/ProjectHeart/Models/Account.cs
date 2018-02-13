namespace ProjectHeart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public class Account 
    {
        [Key]
        public int ID_USER { get; set; }

        [Required(ErrorMessage = "Informe o E-mail!")]
        [Display(Name = "E-mail")]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Informe um E-mail válido.")]
        public string EMAIL { get; set; }

        [Required(ErrorMessage = "Informe a tipo do profissional!")]
        [Display(Name = "Tipo")]
        [StringLength(20)]
        public string TIPO { get; set; }

        [Required(ErrorMessage = "Informe a Senha!")]
        [Display(Name = "Senha")]
        [StringLength(20)]
        [DataType(DataType.Password)]
        public string SENHA { get; set; }

        [Display(Name = "Log")]
        public DateTime DATA_LOG { get; set; }
    }

    public class ForgotPassword
    {
        [Required(ErrorMessage = "Informe o E-mail!")]
        [Display(Name = "E-mail")]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Informe um E-mail válido.")]
        public string EMAIL { get; set; }
    }


}

