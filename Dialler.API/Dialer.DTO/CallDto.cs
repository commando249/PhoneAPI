using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dialler.API.Dialer.Data;

namespace Dialler.API.Dialer.DTO
{
    public class CallDto
    {
        public string CallId { get; set; }

        public string caller { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public CallState State { get; set; }


        public CallType Type { get; set; }

        public MediaSetting MediaSetting { get; set; }
    }
}