using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dialler.API.Dialer.Data;

namespace Dialler.API.Dialer.DTO
{
    public class MessageDto
    {
        public string MessagId { get; set; }

        public string Sender { get; set; }

        public string Receiver { get; set; }

        public string Content { get; set; }

        public DateTime TimeStamp { get; set; }

        public bool IsSent { get; set; }

        public bool IsRead { get; set; }

        public string? AttachmentUrl { get; set; }

        public MessageType TypeOfMessage { get; set; }
    }
}