using Microsoft.EntityFrameworkCore;
using Template_web.Core.Entities;
using Template_web.Core.Interfaces;

namespace Template_web.Infrastructure.Persistence.Repository
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly DatabaseContext _databaseContext;
        public UserRoleRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<UserRoleModel?> GetUserRoleModelByNIK(string NIKName)
        {
            return await _databaseContext.AspNetUserRole
                 .FirstOrDefaultAsync(ur => ur.UserNik == NIKName);
        }
    }
}
