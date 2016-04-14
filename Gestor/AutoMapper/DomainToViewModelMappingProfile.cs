using AutoMapper;
using Gestao.Domain.Entities;
using Gestor.ViewModels;

namespace Gestor.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "DomainToViewModelMappings";

        protected override void Configure()
        {
            CreateMap<EstacaoViewModel, Estacao>();
            CreateMap<ImpressoraViewModel, Impressora>();
        }
    }
}