using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace Dialler.API.Dialer.Data
{
	public class Message
	{
		[Key]
		public string MessagId { get; set; }
		
		[Required]
		public string Sender { get; set; }
		
		[Required]
		public string Receiver { get; set; }
		
		[Required]
		public string Content { get; set; }
		
		public DateTime TimeStamp { get; set; }
		
		public bool IsSent { get; set; }
		
		public bool IsRead { get; set; }
		
		public string? AttachmentUrl { get; set; }
		
		public MessageType TypeOfMessage { get; set; }

	}
	
	public enum MessageType {Text,Image,Video,File}
}