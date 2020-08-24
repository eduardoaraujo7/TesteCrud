using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMVC.Models
{
    [Table("Historico")]
    public class Historico
    {
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("DetalhesHitorico")]
        [Display(Name = "Detalhes Historico")]
        public string DetalhesHistorico { get; set; }

        [Column("EmailUsuario")]
        [Display(Name = "Email Usuario")]
        public string EmailUsuario { get; set; }

    }
}
