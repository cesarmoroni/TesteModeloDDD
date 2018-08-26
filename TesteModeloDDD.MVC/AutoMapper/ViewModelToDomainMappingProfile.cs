
using AutoMapper;
using TesteModeloDDD.Domain.Entities;
using TesteModeloDDD.MVC.ViewModels;

namespace TesteModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
            Mapper.CreateMap<Livro, LivroViewModel>();
        }
    }
}