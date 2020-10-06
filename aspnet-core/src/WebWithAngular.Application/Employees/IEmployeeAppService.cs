using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using WebWithAngular.Employees.Dto;

namespace WebWithAngular.Employees
{
    public interface IEmployeeAppService : IAsyncCrudAppService<EmployeeDto ,Guid>
    {
    }
}
