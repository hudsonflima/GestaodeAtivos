using AutoMapper;
using Gestao.Domain.Entities;
using Gestor.ViewModels;


namespace Gestor.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName => "ViewModelToDomainMappings";

        protected override void Configure()
        {
            CreateMap<ImpressoraViewModel, Impressora>();
            CreateMap<EstacaoViewModel, Estacao>();
        }
    }
}