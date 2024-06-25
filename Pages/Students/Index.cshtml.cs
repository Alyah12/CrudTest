using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudTest.Data;
using CrudTest.Models;

namespace CrudTest.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly CrudTest.Data.ApplicationDbContext _context;

        public IndexModel(CrudTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Students> Students { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Students = await _context.Students.ToListAsync();
            }
        }
    }
}
