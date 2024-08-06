using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoPizza.Data;
using ContosoPizza.Models;

namespace GettingStarted_EFCore_p3.Pages.Products
{
    public class IndexModel : PageModel
    {

        private readonly ContosoPizza.Data.ContosoPizzaPart1Context _context;

        public IndexModel(ContosoPizza.Data.ContosoPizzaPart1Context context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
