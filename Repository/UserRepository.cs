using NetCore_Repository_Pattern.Context;
using NetCore_Repository_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_Repository_Pattern.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }
        public AppDbContext _context
        {
            get { return _context; }
        }
    }
}
