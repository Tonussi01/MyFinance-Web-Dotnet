using AutoMapper;
using Myfinance_web_dotnet.Domain;
using Myfinance_web_dotnet.Models;

namespace Myfinance_web_dotnet.Mappers{

    public class TransacaoMap : Profile
    {      
        public TransacaoMap(){
            CreateMap<Transacao, TransacaoModel>()
            .ForMember(dest => dest.ItemPlanoConta, opt => opt.MapFrom(src => src.PlanoConta))
            .ReverseMap();
        }

    }
}