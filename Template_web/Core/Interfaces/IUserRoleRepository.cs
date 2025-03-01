using Template_web.Core.Entities;

namespace Template_web.Core.Interfaces
{
    public interface IUserRoleRepository
    {
        public Task<UserRoleModel?> GetUserRoleModelByNIK(string NIKName);
    }
}
