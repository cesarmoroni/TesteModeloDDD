using System;
using System.Collections.Generic;

namespace TesteModeloDDD.Domain.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Nome { get; set; }
        public string Isbn { get; set; }
        public string Autor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int QtdeEstoque { get; set; }
        public decimal Valor { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        public bool LivronoEstoque(Livro livro)
        {
            return livro?.QtdeEstoque > 0;
        }
    }
}
