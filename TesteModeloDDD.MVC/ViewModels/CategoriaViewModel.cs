

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TesteModeloDDD.MVC.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        
        public bool Ativo { get; set; }
        public virtual IEnumerable<LivroViewModel> Livros { get; set; }
    }
}