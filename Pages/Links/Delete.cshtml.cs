using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using J2.Data;
using J2.Models;

namespace J2.Pages.Links
{
    public class DeleteModel : PageModel
    {
        private readonly J2.Data.VendorContext _context;

        public DeleteModel(J2.Data.VendorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Link Link { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Link = await _context.Link
                .Include(l => l.Vendor).FirstOrDefaultAsync(m => m.LinkID == id);

            if (Link == null)
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

            Link = await _context.Link.FindAsync(id);

            if (Link != null)
            {
                _context.Link.Remove(Link);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
