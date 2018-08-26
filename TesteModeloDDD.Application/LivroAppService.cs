
using System.Collections.Generic;
using TesteModeloDDD.Application.Interface;
using TesteModeloDDD.Domain.Entities;
using TesteModeloDDD.Domain.Interfaces.Services;

namespace TesteModeloDDD.Application
{
    public class LivroAppService : AppServiceBase<Livro>, ILivroAppService
    {
        private readonly ILivroService _LivroService;

        public LivroAppService(ILivroService LivroService)
            : base(LivroService)
        {
            _LivroService = LivroService;
        }

        public IEnumerable<Livro> BuscarIsbn(string Isbn)
        {
            return _LivroService.BuscaIsbn(Isbn);
        }

      
    }
}
