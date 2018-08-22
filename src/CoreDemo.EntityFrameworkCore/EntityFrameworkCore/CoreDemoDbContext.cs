using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CoreDemo.Authorization.Roles;
using CoreDemo.Authorization.Users;
using CoreDemo.MultiTenancy;

namespace CoreDemo.EntityFrameworkCore
{
    public class CoreDemoDbContext : AbpZeroDbContext<Tenant, Role, User, CoreDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CoreDemoDbContext(DbContextOptions<CoreDemoDbContext> options)
            : base(options)
        {
        }
    }
}
