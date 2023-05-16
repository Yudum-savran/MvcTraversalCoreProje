using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Models
{
    public class MailRequest
    {
        public string Name { get; set; }
        public string SenderMail { get; set; } // gönderen 
        public string ReceiverMail { get; set; } //alıcı
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
