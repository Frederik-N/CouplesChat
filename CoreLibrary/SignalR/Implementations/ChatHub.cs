using Microsoft.AspNetCore.SignalR;

namespace CoreLibrary.SignalR.Implementations
{
    class ChatHub : Hub
    {
        public async Task SendMessage(string username, string message)
        {
            await Clients.All.SendAsync("recieveMessage", username, message);
        }
    }
}
