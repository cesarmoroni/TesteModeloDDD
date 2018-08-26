

using System.Collections.Generic;
using TesteModeloDDD.Application.Interface;
using TesteModeloDDD.Domain.Entities;
using TesteModeloDDD.Domain.Interfaces.Services;

namespace TesteModeloDDD.Application
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaAppService
    {
        private readonly ICategoriaService _CategoriaService;

        public CategoriaAppService(ICategoriaService CategoriaService)
            : base(CategoriaService)
        {
            _CategoriaService = CategoriaService;
        }
        
    }
}
