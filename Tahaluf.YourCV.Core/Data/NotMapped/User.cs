using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahaluf.YourCV.Core.Data
{
    public partial class User
    {
        [NotMapped]
        public string RoleName { get; set; }
    }
}
