using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMvcMysql.Models
{
    [Table("Usuario")] //nome tabela para criação
    public class Usuario
    {
        [Display(Name = "código")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Name { get; set; }

        [Display(Name = "RG")]
        [Column("RG")]
        public string RG { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string Email{ get; set; }


    }
}
