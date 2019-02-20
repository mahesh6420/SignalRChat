using Microsoft.AspNetCore.Identity;
using SignalRChat.Models.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChat.Models.Users
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<UserGroup> UserGroups { get; set; }
        public List<Connection> Connections { get; set; }
    }
}
