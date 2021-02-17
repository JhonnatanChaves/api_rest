using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.API.Domains.Models;

namespace api_rest.Domains.Repositories
{
    interface ICategoryRepository
    {

        Task<IEnumerable<Category>> ListAsync();

    }
}
