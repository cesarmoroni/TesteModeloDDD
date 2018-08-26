
using AutoMapper;
using TesteModeloDDD.Domain.Entities;
using TesteModeloDDD.MVC.ViewModels;

namespace TesteModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
            Mapper.CreateMap<LivroViewModel, Livro>();
        }
    }
}