using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole.EmployeeRoleProfile
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
            CreateMap<Dtos.EnployeeRole.EmployeeRoleDto, Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("roleName", opt => opt.MapFrom(src => src.Cargo));

            //CreateMap<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, Dtos.EnployeeRole.EmployeeRoleDto>()
            //     .ForMember ("roleName", opt => opt.MapFrom(src => src.Cargo));

        }

    }
}
