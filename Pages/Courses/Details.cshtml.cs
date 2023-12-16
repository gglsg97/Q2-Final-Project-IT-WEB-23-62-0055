using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentsInformation.Data;
using StudentsInformation.Models;

namespace StudentsInformation.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly StudentsInformation.Data.StudentsInformationContext _context;

        public DetailsModel(StudentsInformation.Data.StudentsInformationContext context)
        {
            _context = context;
        }

        public Course Course { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Courses
            .Include(s => s.Students)
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.CourseID == id);

            if (Course == null)
            {
                return NotFound();
            }
           
            return Page();
        }
    }
}
