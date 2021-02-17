using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.API.Domains.Models;

namespace api_rest.Domains.Services
{
    
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService _categoryRepository;

        public CategoryService(ICategoryService categoryRepository) 
        {

            this._categoryRepository = categoryRepository;

        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
