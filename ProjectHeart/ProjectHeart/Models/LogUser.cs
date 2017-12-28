namespace ProjectHeart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogUser")]
    public class LogUser
    {
        [Key]
        public int ID_USER { get; set; }

        [StringLength(50)]
        public string NOME { get; set; }

        //estudar logic para melhorar login
        //[Required]
        [Column(TypeName = "char")]
        public string TIPO { get; set; }

        [Required(ErrorMessage = "Por favor, informe o E-mail!")]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string EMAIL { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Senha!")]
        [Display(Name = "Senha")]
        public string SENHA { get; set; }
    }

}

