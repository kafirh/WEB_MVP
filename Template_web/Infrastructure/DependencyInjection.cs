using Microsoft.EntityFrameworkCore;
using Template_web.Application.Services;
using Template_web.Application.Services.ServiceInterfaces;
using Template_web.Core.Interfaces;
using Template_web.Infrastructure.Auth;
using Template_web.Infrastructure.Persistence;
using Template_web.Infrastructure.Persistence.Repository;

namespace Template_web.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            // Registrasi DatabaseContext
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(connectionString));

            // Registrasi repository agar bisa digunakan di Application Layer
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();

            // Registrasi untuk mengakses HttpContext (dibutuhkan untuk CookieAuth)
            services.AddHttpContextAccessor();

            // Registrasi Auth Session Service untuk menangani login menggunakan Cookie
            services.AddScoped<IAuthSessionService, AuthSessionService>();

            //  Registrasi Auth Service
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }

}
