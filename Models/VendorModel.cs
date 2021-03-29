using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace J2.Models
{
    public class Vendor
    {
        [Column("VendorID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int VendorID { get; set; }

        [Column(Order=1)]
        [Required]
        [Display(Name = "Vendor Name")]
        public string vendorName { get; set; }
        
        public string logo { get; set; }
        
        [Display(Name = "Support Phone")]
        public string supportPhone { get; set; }
        
        [Display(Name = "Main Web Site")]
        public string mainUrl { get; set; }
        
        [Display(Name = "Support URL")]
        public string supportUrl { get; set; }
        
        [Display(Name = "Support E-Mail")]
        public string supportEmail { get; set; }

        // List of Links associated with Vendor
        public List<Link> links { get; set; }
    }
}