using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DeleteEFDemo.Models;

namespace DeleteEFDemo.Pages.Farm
{
    public class CreateModel : PageModel
    {
        private readonly DeleteEFDemo.Models.FarmContext _context;

        public CreateModel(DeleteEFDemo.Models.FarmContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Farm Farm { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Farms.Add(Farm);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}