using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteModeloDDD.Domain.Entities;
using TesteModeloDDD.Domain.Interfaces.Repositories;

namespace TesteModeloDDD.Infra.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        public IEnumerable<Livro> BuscaIsbn(string Isnb)
        {
            return Db.Livros.Where(p => p.Isbn == Isnb);
        }
    }
}
