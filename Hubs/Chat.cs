using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    [Authorize]
    public class Chat : Hub
    {
        public async Task BroadcastMessage(string message)
        {
            await Clients.All.SendAsync("newMessage", new
            {
                Sender = Context.User.Identity.Name,
                Message = message
            });
        }
    }
}