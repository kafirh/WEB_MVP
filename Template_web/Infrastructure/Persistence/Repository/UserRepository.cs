using Microsoft.EntityFrameworkCore;
using Template_web.Core.Entities;
using Template_web.Core.Interfaces;

namespace Template_web.Infrastructure.Persistence.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _databaseContext;
        public UserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<UserModel?> GetUserByNIK(string NIKName)
        {
            return await _databaseContext.AspNetUsers
                .FirstOrDefaultAsync(user => user.NIK == NIKName);
        }
    }
}
