using Template_web.Core.Entities;

namespace Template_web.Core.Interfaces
{
    public interface IRoleRepository
    {
        public Task<RoleModel?> GetRoleModelById(string roleId);
    }
}
