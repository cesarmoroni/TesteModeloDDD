

using System.Collections.Generic;
using System.Linq;
using TesteModeloDDD.Domain.Entities;
using TesteModeloDDD.Domain.Interfaces.Repositories;
using TesteModeloDDD.Domain.Interfaces.Services;

namespace TesteModeloDDD.Domain.Services
{
    public class CategoriaService : ServiceBase<Categoria>, ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
            : base(categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

    }
}
