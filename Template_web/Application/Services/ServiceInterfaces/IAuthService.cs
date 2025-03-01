using Template_web.Application.DTO;

namespace Template_web.Application.Services.ServiceInterfaces
{
    public interface IAuthService
    {
        Task<bool> LoginAsync(LoginRequestDTO request);
        Task LogoutAsync();
    }
}
