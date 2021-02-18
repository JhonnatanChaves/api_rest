﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using api_rest.Domains.Repositories;
using api_rest.Persistence.Contexts;
using Supermarket.API.Domains.Models;
using Microsoft.EntityFrameworkCore;

namespace api_rest.Persistence.Repositories 
{
	public class CategoryRepository : BaseRepository, ICategoryRepository 
	{
		public CategoryRepository(AppDbContext context) : base (context)
		{
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }

}

