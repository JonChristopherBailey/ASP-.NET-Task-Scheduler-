using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Job.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Job.Pages.JobPages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _db;

        [TempData]
        public string afterAddMessage { get; set; }

        public IndexModel(ApplicationDbContext db)

        {
            _db = db;
        }

          public IEnumerable<Tasks> myTasks { get; set; }

      

        public async Task OnGet()
        {
            myTasks = await _db.TaskItems.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var theTask = _db.TaskItems.Find(id);
            _db.TaskItems.Remove(theTask);
            await _db.SaveChangesAsync();
            afterAddMessage = "Connection deleted successfully!";
            return RedirectToPage();
        }
    }
}