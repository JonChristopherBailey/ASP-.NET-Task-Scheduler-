using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Job.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Job.Pages.JobPages
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Tasks Mytasks { set; get; }

        [TempData]
        public string afterAddMessage { set; get; }

        public void OnGet(int id)
        {
            Mytasks = _db.TaskItems.Find(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var MytasksInDb = _db.TaskItems.Find(Mytasks.ID);
                MytasksInDb.TaskDescription = Mytasks.TaskDescription;
                MytasksInDb.TaskName = Mytasks.TaskName;
                MytasksInDb.TaskSchedule = Mytasks.TaskSchedule;

                await _db.SaveChangesAsync();

                afterAddMessage = " Task updated successfully";

                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}