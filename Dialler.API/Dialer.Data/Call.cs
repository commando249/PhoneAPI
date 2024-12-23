using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dialler.API.Dialer.Data
{
	public class Call
	{

		public string CallId { get; set; }

		public string caller { get; set; }

		public DateTime StartTime { get; set; }

		public DateTime? EndTime { get; set; }

		public CallState State { get; set; }
		
		
		public CallType Type { get; set; }
		
		public MediaSetting MediaSetting { get; set; }

	}

	public enum CallState { Ringing, Connected, OnHold, Ended }

	public enum CallType { Voice, Video }
}