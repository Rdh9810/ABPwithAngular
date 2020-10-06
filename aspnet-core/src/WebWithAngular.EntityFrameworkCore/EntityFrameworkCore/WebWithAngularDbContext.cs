using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using WebWithAngular.Authorization.Roles;
using WebWithAngular.Authorization.Users;
using WebWithAngular.MultiTenancy;
using WebWithAngular.Employees;

namespace WebWithAngular.EntityFrameworkCore
{
    public class WebWithAngularDbContext : AbpZeroDbContext<Tenant, Role, User, WebWithAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Employee> Employees { get; set; }        
        public WebWithAngularDbContext(DbContextOptions<WebWithAngularDbContext> options)
            : base(options)
        {
        }
    }
}
