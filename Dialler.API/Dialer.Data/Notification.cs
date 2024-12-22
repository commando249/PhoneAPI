using System;

namespace Dialler.API.Dialer.Data;

public class Notification
{
	public string NotificationId { get; set; }
	
	
	public string Title { get; set; }
	
	public string Message { get; set; }
	
	public DateTime TimeStamp { get; set; }
	
	public bool IsRead { get; set; }

	public NotificationType Type { get; set; }
}

public enum NotificationType {IncomingCall, MissedCall, NewMessage, SystemAlert}
