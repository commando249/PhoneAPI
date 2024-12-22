using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dialler.API.Dialer.Data;

namespace Dialler.API.Dialer.DTO
{
    public class MediaSettingDto
    {
        public string AudioCodec { get; set; }
		
		public string VideoCodec { get; set; }
		
		public int JitterBufferSize { get; set; }
		
		public bool EnableEchoCancellation { get; set; }
		
		public bool EnableNoiseSuppression { get; set; }
		
		public Resolution Resolution { get; set; }
    }
}