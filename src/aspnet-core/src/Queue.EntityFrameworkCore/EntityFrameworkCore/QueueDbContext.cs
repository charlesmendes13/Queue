using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Queue.Authorization.Roles;
using Queue.Authorization.Users;
using Queue.MultiTenancy;

namespace Queue.EntityFrameworkCore
{
    public class QueueDbContext : AbpZeroDbContext<Tenant, Role, User, QueueDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public QueueDbContext(DbContextOptions<QueueDbContext> options)
            : base(options)
        {
        }
    }
}
