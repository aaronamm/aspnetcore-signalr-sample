using Microsoft.AspNetCore.SignalR;

namespace AspNetCoreSignalR;

public class PingHub : Hub
{
    public PingHub()
    {

    }

    public override async Task OnConnectedAsync()
    {
        await Clients.Caller.SendAsync("receivedMessage", "Pong pong ...");
    }

}
