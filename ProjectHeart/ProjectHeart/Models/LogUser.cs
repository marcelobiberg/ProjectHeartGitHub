namespace ProjectHeart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogUser")]
    public partial class LogUser
    {
        [Key]
        public int ID_USER { get; set; }

        [StringLength(50)]
        public string NOME { get; set; }

        [Required]
        public string EMAIL { get; set; }

        [Required]
        public string SENHA { get; set; }

        [Required]
        [Column(TypeName = "char")]
        public string TIPO { get; set; }
    }
}
