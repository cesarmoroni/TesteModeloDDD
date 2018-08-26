
using System.Collections.Generic;
using TesteModeloDDD.Domain.Entities;

namespace TesteModeloDDD.Application.Interface
{
    public interface ILivroAppService : IAppServiceBase<Livro>
    {
        IEnumerable<Livro> BuscarIsbn(string Isbn);
    }
}
