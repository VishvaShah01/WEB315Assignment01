using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorWebAssemblySignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            if(user == " ") {
                await Clients.Caller.SendAsync("ReceiveMessage", "Anonymous", message);
            } else {
                await Clients.Others.SendAsync("ReceiveMessage", user, message);
            }
        }
    }
}