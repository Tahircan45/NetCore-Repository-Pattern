using NetCore_Repository_Pattern.Context;
using NetCore_Repository_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_Repository_Pattern.Repository
{
    public class ProductRepository : Repository<Product>,IProductRepository
    {
        public ProductRepository(AppDbContext context):base (context)
        {
                
        }
        public IEnumerable<Product> TopProducts()
        {
            return _context.products.OrderBy(p => p.price).ToList();
        }
        public AppDbContext _context
        {
            get { return _context; }
        }

    }
}
