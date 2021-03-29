using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using J2.Data;
using J2.Models;

namespace J2.Pages.Links
{
    public class CreateModel : PageModel
    {
        private readonly J2.Data.VendorContext _context;

        public CreateModel(J2.Data.VendorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["VendorID"] = new SelectList(_context.Vendor, "VendorID", "vendorName");
            return Page();
        }

        [BindProperty]
        public Link Link { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Link.Add(Link);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
