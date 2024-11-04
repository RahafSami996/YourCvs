using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahaluf.YourCV.Core.Data
{
    public class WebsiteInfo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string HeadLine { get; set; }
        public string Logo { get; set; }
        public string Background { get; set; }
        public string Conclusion { get; set; }

        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual WebsiteInfo Role { get; set; }

    }
}
