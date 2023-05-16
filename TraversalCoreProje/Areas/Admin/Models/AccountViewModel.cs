using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Admin.Models
{
    public class AccountViewModel
    {
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public decimal Amount { get; set; }
        //public decimal SenderNewBalanace { get; set; }
        //public decimal ReceiverNewBalanace { get; set; }
    }
}
