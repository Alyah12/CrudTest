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
    public class DetailsModel : PageModel
    {
        private readonly CrudTest.Data.ApplicationDbContext _context;

        public DetailsModel(CrudTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Models.Students Students { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var students = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);
            if (students == null)
            {
                return NotFound();
            }
            else 
            {
                Students = students;
            }
            return Page();
        }
    }
}
