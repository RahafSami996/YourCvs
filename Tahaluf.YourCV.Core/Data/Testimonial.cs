using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahaluf.YourCV.Core.Data
{
    public class Testimonial
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int WebsiteInfoId { get; set; }

        [ForeignKey("WebsiteInfoId")]
        public virtual WebsiteInfo WebsiteInfo { get; set; }
    }
}
