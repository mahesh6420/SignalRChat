using SignalRChat.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChat.Models.Chat
{
    public class Conversation : BaseModel
    {
        public string SenderId { get; set; }
        public Guid GroupId { get; set; }
        public string Message { get; set; }

        public ApplicationUser Sender { get; set; }
        public Group Group { get; set; }
    }
}
