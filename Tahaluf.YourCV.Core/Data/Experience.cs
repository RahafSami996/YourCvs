using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahaluf.YourCV.Core.Data
{
    public class Experience
    { 
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string Employer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string DateTime { get; set; }
        public int ResumeId { get; set; }
    }
}
