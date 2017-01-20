using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZumraApp.Data.Model.Models.Messages
{
    public class Messages
    {
        public int MessageID { get; set; }

        public Guid SenderMember { get; set; }

        public Guid ReceiverMember { get; set; }

        public string MailMessage { get; set; }

        public DateTime Date { get; set; }

        public bool Seen { get; set; }



    }
}
