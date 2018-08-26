using System;
using System.Collections.Generic;

namespace TesteModeloDDD.Domain.Entities
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Livro> Livros { get; set; }
       
    }
}
