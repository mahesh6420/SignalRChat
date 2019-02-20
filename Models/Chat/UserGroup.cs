using SignalRChat.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChat.Models.Chat
{
    public class UserGroup
    {
        [Key]
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }
    }
}
