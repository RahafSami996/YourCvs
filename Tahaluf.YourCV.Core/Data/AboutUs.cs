using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahaluf.YourCV.Core.Data
{
    public class AboutUs
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("WebsiteInfoId")]
        public int WebsiteInfoId { get; set; }
        public String Information { get; set; }
        public String CenterImage { get; set; }
        public String SideImage { get; set; }
        public virtual WebsiteInfo websiteInfo { get; set; }
    }
}
