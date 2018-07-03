using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Job.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Job.Pages.JobPages
{
    public class createModel : PageModel
    {
        private ApplicationDbContext _db;

        public createModel(ApplicationDbContext db)

        {
            _db = db;
        }

        [TempData]
        public string afterAddMessage { get; set; }

        [BindProperty]
        public Tasks Mytask { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                return Page();

            }
            else
            {
                _db.TaskItems.Add(Mytask);
                await _db.SaveChangesAsync();
                afterAddMessage = "New Task Made!";
                return RedirectToPage("Index");

            }
        }
    }
}




        
    