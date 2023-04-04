using AmApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AmApi.Data.Contexts
{
    public class AmProfileContext :IdentityDbContext<UserModel, RoleModel, int, UserClaimModel, UserRoleModel, UserLoginModel, RoleClaimModel, UserTokenModel>
    {
        public AmProfileContext(DbContextOptions<AmProfileContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<RoleClaimModel>().ToTable("RoleClaim");
            builder.Entity<UserClaimModel>().ToTable("UserClaim");
            builder.Entity<UserLoginModel>().ToTable("UserLogin");
            builder.Entity<UserModel>().ToTable("User"); //.Property(p => p.Id).HasColumnName("Id");
            builder.Entity<RoleModel>().ToTable("Role");
            builder.Entity<UserRoleModel>().ToTable("UserRole");
            builder.Entity<UserTokenModel>().ToTable("UserToken");
        }
    }
}
