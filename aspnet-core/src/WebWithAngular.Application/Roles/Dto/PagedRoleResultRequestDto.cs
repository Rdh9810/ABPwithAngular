using Abp.Application.Services.Dto;

namespace WebWithAngular.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

