
using System.Collections.Generic;
using TesteModeloDDD.Domain.Entities;
using TesteModeloDDD.Domain.Interfaces;

namespace TesteModeloDDD.Domain.Interfaces.Repositories
{
    public interface ILivroRepository: IRepositoryBase<Livro>
    {
        IEnumerable<Livro> BuscaIsbn(string Isnb);
    }
}
