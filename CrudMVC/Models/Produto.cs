using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMVC.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("ProdutoId")]
        [Display(Name = "Codigo")]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Maximo (0) caracteres")]
        [MinLength(2, ErrorMessage = "Minimo (0) caracteres")]
        public string Nome { get; set; }

        [Column("Valor")]
        [Display(Name = "Valor")]
        [DataType(DataType.Currency)]
        public string Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }
    }
}
