using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using J2.Data;
using J2.Models;
using Microsoft.EntityFrameworkCore;

namespace J2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly J2.Data.VendorContext _context;

        public IndexModel(J2.Data.VendorContext context)
        {
            _context = context;
        }

        public IList<J2.Models.Vendor> Vendor { get; set; }

        public void OnGet()
        {
            // Vendor = _context.Vendor.ToList();
            Vendor = _context.Vendor
                .Include( v => v.links)
                .ToList();
        }
    }
}
