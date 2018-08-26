
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TesteModeloDDD.MVC.ViewModels
{
    public class LivroViewModel
    {
        [Key]
        public int LivroId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Preencha o campo Isbn")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Isbn { get; set; }

        [Required(ErrorMessage = "Preencha o campo Autor")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Autor { get; set; }

        [DisplayName("Estoque")]
        [Required(ErrorMessage = "Preencha o campo Qtde")]
        public int QtdeEstoque { get; set; }
        

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Ativo")]
        public bool Ativo { get; set; }

        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }
        public virtual CategoriaViewModel Categoria { get; set; }
    }
}