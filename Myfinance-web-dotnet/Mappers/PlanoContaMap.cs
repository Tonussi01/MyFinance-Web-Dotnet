using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Myfinance_web_dotnet.Domain;
using Myfinance_web_dotnet.Models;

namespace Myfinance_web_dotnet.Mappers{

    public class PlanoContaMap : Profile
    {      
        public PlanoContaMap(){
            CreateMap<PlanoConta, PlanoContaModel>().ReverseMap();
        }

    }
}