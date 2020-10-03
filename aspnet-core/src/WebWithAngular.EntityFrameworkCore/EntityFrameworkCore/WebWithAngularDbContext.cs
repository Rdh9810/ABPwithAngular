using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using WebWithAngular.Authorization.Roles;
using WebWithAngular.Authorization.Users;
using WebWithAngular.MultiTenancy;

namespace WebWithAngular.EntityFrameworkCore
{
    public class WebWithAngularDbContext : AbpZeroDbContext<Tenant, Role, User, WebWithAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WebWithAngularDbContext(DbContextOptions<WebWithAngularDbContext> options)
            : base(options)
        {
        }
    }
}
