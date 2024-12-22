using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dialler.API.Dialer.Data
{
	public class MediaSetting
	{
		public string AudioCodec { get; set; }
		
		public string VideoCodec { get; set; }
		
		public int JitterBufferSize { get; set; }
		
		public bool EnableEchoCancellation { get; set; }
		
		public bool EnableNoiseSuppression { get; set; }
		
		public Resolution Resolution { get; set; }
	}
	
	public class Resolution
	
	{
		public int Width { get; set; }
		public int Height { get; set; }
	}
}