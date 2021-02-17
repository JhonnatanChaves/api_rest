using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.API.Domains.Models;

namespace api_rest.Domains.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<IEnumerable<Category>> ListAsync()
        {
            return null;
        }
    }
}
