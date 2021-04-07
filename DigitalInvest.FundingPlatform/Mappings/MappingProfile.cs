using AutoMapper;
using DigitalInvest.FundingPlatform.DataAccess.Entitities;
using DigitalInvest.FundingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalInvest.FundingPlatform.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FundingViewModel, Funding>()
                .ForMember(dest => dest.Name, opt => opt.Ignore())
                .ForMember(dest => dest.Target, opt => opt.Ignore())
                .ForMember(dest => dest.ExpirationDate, opt => opt.Ignore())
                .ForMember(dest => dest.Investment, opt => opt.Ignore())
                .AfterMap((src, dest) => dest.Investment += src.Investment);

            CreateMap<Funding, FundingViewModel>();
        }
    }
}
