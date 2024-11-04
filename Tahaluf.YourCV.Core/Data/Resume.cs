using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahaluf.YourCV.Core.Data
{
   public class Resume
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }
        public String PersonName { get; set; }
        public String PersonSummary { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        [ForeignKey("TemplateDocumentId ")]
        public int TemplateDocumentId { get; set; }

        public virtual User user{ get; set; }
        public virtual TemplateDocument templateDocument { get; set; }

    }
}
