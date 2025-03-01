using Template_web.Core.Entities;

namespace Template_web.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<UserModel?> GetUserByNIK(string NIKName);
    }
}
