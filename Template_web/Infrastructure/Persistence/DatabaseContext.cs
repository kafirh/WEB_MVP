using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Template_web.Core.Entities;

namespace Template_web.Infrastructure.Persistence
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<UserModel> AspNetUsers { get; set; }
        public DbSet<RoleModel> AspNetRoles { get; set; }
        public DbSet<UserRoleModel> AspNetUserRole { get; set; }
    }
}
