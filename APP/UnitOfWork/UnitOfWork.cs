using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using APP.Repository;
using Domain.Interfaces;
using Persistence.Data;

namespace APP.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private IRole _roles;
        private IUser _users;
        private readonly Veterinary4LApiContext _context;

        public UnitOfWork(Veterinary4LApiContext context)
        {
            _context = context;
        }

        public IRole Roles
        {
            get 
            {
                if (_roles == null)
                {
                    _roles = new RoleRepository(_context);
                }
                return _roles;
            }
        }

        public IUser Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(_context);
                }
                return _users;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}