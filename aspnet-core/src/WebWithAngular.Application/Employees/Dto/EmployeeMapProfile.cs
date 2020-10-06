using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebWithAngular.Employees.Dto
{
    public class EmployeeMapProfile : Profile
    {
        public EmployeeMapProfile()
        {
            CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
