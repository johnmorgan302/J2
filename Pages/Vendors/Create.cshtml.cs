using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using J2.Data;
using J2.Models;

namespace J2.Pages.Vendors
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
            return Page();
        }

        [BindProperty]
        public Vendor Vendor { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vendor.Add(Vendor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
