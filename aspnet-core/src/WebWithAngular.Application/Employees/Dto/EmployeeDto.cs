using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebWithAngular.Employees.Dto
{
    public class EmployeeDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Amount { get; set; }
    }
}
