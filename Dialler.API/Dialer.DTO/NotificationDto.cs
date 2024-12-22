using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dialler.API.Dialer.Data;

namespace Dialler.API.Dialer.DTO
{
    public class NotificationDto
    {
        public string NotificationId { get; set; }


        public string Title { get; set; }

        public string Message { get; set; }

        public DateTime TimeStamp { get; set; }

        public bool IsRead { get; set; }

        public NotificationType Type { get; set; }
    }
}