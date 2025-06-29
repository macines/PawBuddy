namespace PawBuddy.Hubs;

using Microsoft.AspNetCore.SignalR;

public class NotificacaoHub : Hub
{
    public async Task SendNotification(string message)
    {
        await Clients.All.SendAsync("ReceiveNotification", message);
    }
}
