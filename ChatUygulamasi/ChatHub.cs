using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatUygulamasi
{
    public class ChatHub : Hub
    {
        public void Send( string message)
        {
            bool x = false;
            if (message == "Emrah" && x == false)
            {
                message = "Senol";
                Clients.All.sendMessage(message);
                x = true;
            }
            if (message == "Senol" && x == false)
            {
                message = "Ali";
                Clients.All.sendMessage(message);
            }
        }
    }
}