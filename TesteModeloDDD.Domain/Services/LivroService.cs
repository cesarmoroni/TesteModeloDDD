
using System.Collections.Generic;
using TesteModeloDDD.Domain.Entities;
using TesteModeloDDD.Domain.Interfaces.Repositories;
using TesteModeloDDD.Domain.Interfaces.Services;

namespace TesteModeloDDD.Domain.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _LivroRepository;

        public LivroService(ILivroRepository LivroRepository)
            : base(LivroRepository)
        {
            _LivroRepository = LivroRepository;
        }

        public IEnumerable<Livro> BuscaIsbn(string Isbn)
        {
            return _LivroRepository.BuscaIsbn(Isbn);
        }

        
    }
}
