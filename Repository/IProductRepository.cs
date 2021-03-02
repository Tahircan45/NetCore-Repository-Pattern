using NetCore_Repository_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_Repository_Pattern.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> TopProducts();
    }
}
