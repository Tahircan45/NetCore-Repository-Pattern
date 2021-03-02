using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_Repository_Pattern.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public int price { get; set; }
    }
}
