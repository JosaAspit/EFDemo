using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeleteEFDemo.Models;

namespace DeleteEFDemo.Pages.Farm
{
    public class DeleteModel : PageModel
    {
        private readonly DeleteEFDemo.Models.FarmContext _context;

        public DeleteModel(DeleteEFDemo.Models.FarmContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Farm Farm { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Farm = await _context.Farms.FirstOrDefaultAsync(m => m.Id == id);

            if (Farm == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Farm = await _context.Farms.FindAsync(id);

            if (Farm != null)
            {
                _context.Farms.Remove(Farm);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
