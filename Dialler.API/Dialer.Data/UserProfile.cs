using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dialler.API.Dialer.Data
{
	public class UserProfile
	{
		public int UserProfileId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int PhoneNumber { get; set; }
		public string UserRole { get; set; }
		
		
		
	}
}