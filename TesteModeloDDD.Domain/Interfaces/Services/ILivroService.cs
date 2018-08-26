using System.Collections.Generic;
using TesteModeloDDD.Domain.Entities;

namespace TesteModeloDDD.Domain.Interfaces.Services
{
    public interface ILivroService : IServiceBase<Livro>
    {
        IEnumerable<Livro> BuscaIsbn(string nome);
    }
}
