using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dialler.API.Dialer.Data;

namespace Dialler.API.Dialer.DTO
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public UserProfile UserProfileId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}