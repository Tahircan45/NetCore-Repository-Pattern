using NetCore_Repository_Pattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_Repository_Pattern.Services
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository Products { get; }
        IUserRepository Users { get; }
        int Complete();
    }
}
