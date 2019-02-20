using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChat.Models.Chat
{
    public class Group : BaseModel
    {
        public string GroupName { get; set; }

        public List<UserGroup> UserGroups { get; set; }
    }
}
