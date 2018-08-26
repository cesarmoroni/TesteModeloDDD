using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteModeloDDD.Domain.Entities;
using TesteModeloDDD.Domain.Interfaces.Repositories;

namespace TesteModeloDDD.Infra.Data.Repositories
{
    public class CategoriaRepository:RepositoryBase<Categoria>, ICategoriaRepository
    {

    }
}
