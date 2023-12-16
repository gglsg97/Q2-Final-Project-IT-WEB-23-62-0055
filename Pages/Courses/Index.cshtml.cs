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
    public class IndexModel : PageModel
    {
        private readonly StudentsInformation.Data.StudentsInformationContext _context;

        public IndexModel(StudentsInformation.Data.StudentsInformationContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Course = await _context.Courses.ToListAsync();
        }
    }
}
