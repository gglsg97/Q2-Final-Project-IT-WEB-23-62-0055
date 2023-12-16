using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentsInformation.Data;
using StudentsInformation.Models;
using StudentsInformation.Models.DetailsViewModels;

namespace StudentsInformation.Pages
{
    public class AllDetailsModel : PageModel
    {
        private readonly StudentsInformation.Data.StudentsInformationContext _context;

        public AllDetailsModel(StudentsInformation.Data.StudentsInformationContext context)
        {
            _context = context;
        }

        public IList<Student> Students { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Students = await _context.Students
                .Include(s => s.Course).AsNoTracking().ToListAsync();
        }

        /* public async Task OnGetAsync()
         {
             IQueryable<EnrollmentDateGroup> data =
                 from student in _context.Students
                 group student by student.EnrollmentDate into dateGroup
                 select new EnrollmentDateGroup()
                 {
                     EnrollmentDate = dateGroup.Key,
                     StudentCount = dateGroup.Count()
                 };

             Students = await data.AsNoTracking().ToListAsync();
         }*/
    }
}
