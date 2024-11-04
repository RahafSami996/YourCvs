using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahaluf.YourCV.Core.Data
{
   public class CreditCard
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Number { get; set; }
        public int CCV{ get; set; }
        public DateTime ExpiryDate { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public double Balance { get; set; }
        public virtual User user{ get; set; }

    }
}
