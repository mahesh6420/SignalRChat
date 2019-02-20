using SignalRChat.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChat.Models.Chat
{
    public class Connection
    {
        [Key]
        public Guid Id { get; set; }
        public string ConnectionId { get; set; }
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
