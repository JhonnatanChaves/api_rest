using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domains.Helpers;
using Supermarket.API.Domains.Models;

namespace api_rest.Domains.Models
{
    public class Product
    {

		public int id { get; set; };

		public string Name { get; set; }

		public short QuatityInPackage { get; set; }

		//enumera as unidades de medida 
		public EUnitOfMeasurement UnitOfMeasurement { get; set; }


		//permite que um produto possua apenas uma categoria
		public int CategoryId { get; set; }
		public Category Category { get; set; }

	}
}