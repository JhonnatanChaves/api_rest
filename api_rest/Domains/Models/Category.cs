using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domains.Models;

namespace Supermarket.API.Domains.Models
{
    
    public class Category
    {


        public int id { get; set; }

        public string Name { get; set; }

        //Essa propriedade de produtos vai permitir que categorias e produtos 
        public IList<Product> Products { get; set; } = new List<Product>();





    }
}