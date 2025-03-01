namespace Template_web.Core.Interfaces
{
    public interface IAuthSessionService
    {
        Task SignInAsync(string userId, string userName, string role);
        Task SignOutAsync();
    }
}
