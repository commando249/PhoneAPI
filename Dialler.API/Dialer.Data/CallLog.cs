using System;

namespace Dialler.API.Dialer.Data;

public class CallLog
{
	public string LogId { get; set; }

	public string Caller { get; set; }

	public string Callee { get; set; }

	public DateTime TimeStamp { get; set; }

	public CallType Type { get; set; }

	public TimeSpan Duration { get; set; }

	public bool WasMissed { get; set; }
}
