using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahaluf.YourCV.Core.Data
{
    public class Language
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }
        public string Name{ get; set; }
        public String Level{ get; set; }
        
        [ForeignKey("ResumeId")]
        public int ResumeId{ get; set; }
        public virtual Resume resume { get; set; }

    }
}
