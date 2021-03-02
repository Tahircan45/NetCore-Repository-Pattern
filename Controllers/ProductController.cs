using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore_Repository_Pattern.Model;
using NetCore_Repository_Pattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_Repository_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IEnumerable<Product> GetUser()
        {
            return _unitOfWork.Products.GetAll();
        }
    }
}
