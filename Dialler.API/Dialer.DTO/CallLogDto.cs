using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dialler.API.Dialer.Data;

namespace Dialler.API.Dialer.DTO
{
    public class CallLogDto
    {
        public string LogId { get; set; }

        public string Caller { get; set; }

        public string Callee { get; set; }

        public DateTime TimeStamp { get; set; }

        public CallType Type { get; set; }

        public TimeSpan Duration { get; set; }

        public bool WasMissed { get; set; }
    }
}