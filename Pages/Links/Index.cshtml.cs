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
    public class IndexModel : PageModel
    {
        private readonly J2.Data.VendorContext _context;

        public IndexModel(J2.Data.VendorContext context)
        {
            _context = context;
        }

        public IList<Link> Link { get;set; }

        public async Task OnGetAsync()
        {
            Link = await _context.Link
                .Include(l => l.Vendor).ToListAsync();
        }
    }
}
