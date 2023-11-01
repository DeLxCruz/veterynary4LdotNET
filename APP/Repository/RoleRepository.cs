using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace APP.Repository
{
    public class RoleRepository : GenericRepository<Role>, IRole
    {
        private readonly Veterinary4LApiContext context;

        public RoleRepository(Veterinary4LApiContext context) : base(context)
        {
            this.context = context;
        }
    }
}