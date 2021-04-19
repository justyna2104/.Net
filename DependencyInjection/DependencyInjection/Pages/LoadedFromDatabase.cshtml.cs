using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Data;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
    public class LoadedFromDatabaseModel : PageModel
    {
        private readonly ProductContext _context;

        public LoadedFromDatabaseModel(ProductContext context)
        {
            _context = context;

        }

        public IList<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _context.Product.ToList();
        }
    }
}
