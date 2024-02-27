using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR.Hubs
{
    public class SignalingHub : Hub
    {
        public void SendMessage(string targetUserId, string message)
        {
            Clients.User(targetUserId).messageReceived(Context.ConnectionId, message);
        }

        public void StartCall(string targetUserId)
        {
            Clients.User(targetUserId).startCallReceived(Context.ConnectionId);
        }
    }
}