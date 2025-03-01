using Microsoft.EntityFrameworkCore;
using Template_web.Core.Entities;
using Template_web.Core.Interfaces;

namespace Template_web.Infrastructure.Persistence.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DatabaseContext _databaseContext;
        public RoleRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<RoleModel?> GetRoleModelById(string roleId)
        {
            return await _databaseContext.AspNetRoles
                .FirstOrDefaultAsync(r => r.Id == roleId);
        }
    }
}
