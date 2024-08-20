using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<Income, IncomeDto>()
                .ForCtorParam("Id", opt=>opt.MapFrom(x=>x.IncomeId))
                .ForCtorParam("Amount", opt=>opt.MapFrom(x=>x.Amount))
                .ForCtorParam("Date", opt=>opt.MapFrom(x=>x.Date))
                .ForCtorParam("Description", opt=>opt.MapFrom(x=>x.Description));
        }
    }
}
