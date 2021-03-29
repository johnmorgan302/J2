using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace J2.Models
{
    public class Link
    {
        [Column("LinkID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int LinkID { get; set; }

        [Display(Name = "System Name")]
        public string systemName { get; set; }

        [Display(Name = "URL")]
        public string url { get; set; }

        // Foreign key to Vendor Table
        public int VendorID { get; set; }
        public Vendor Vendor { get; set; }
    }
}

// For Reference:
// https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code