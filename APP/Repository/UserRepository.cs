using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace APP.Repository
{
    public class UserRepository : GenericRepository<User>, IUser
    {
        private readonly Veterinary4LApiContext _context;

        public UserRepository(Veterinary4LApiContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetRefreshTokenAsync(string refreshToken)
        {
            return await _context.Users
                .Include(u => u.Roles)
                .Include(u => u.RefreshTokens)
                .FirstOrDefaultAsync(u => u.RefreshTokens.Any(t => t.Token == refreshToken));
        }

        public async Task<User> GetByUsernameAsync(string userName)
        {
            return await _context.Users
                .Include(u => u.RefreshTokens)
                .Include(u => u.Roles)
                .FirstOrDefaultAsync(u => u.Username.ToLower() == userName);
        }
    }
}