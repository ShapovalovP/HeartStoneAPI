using Fleck;
using HeartStoneAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace HeartStoneAPI.Fleck
{
    public class FleckServer
    {
        static Dictionary<string, IWebSocketConnection> ClientConnectedByUserName = new Dictionary<string, IWebSocketConnection>();

        static WebSocketServer server;

        static string userNameCourant = "";
        public static void StartListening()
        {
           
            server = new WebSocketServer("ws://0.0.0.0:8180");
            server.Start(socket =>
            {
                socket.OnClose = () =>
                {
                    ClientConnectedByUserName.Remove(ClientConnectedByUserName.Where(c => c.Value == socket).First().Key);
                };
                socket.OnMessage = message =>
                {
                   

                    UserConnection uc = Deserialize(message);
                    ClientConnectedByUserName.Add(uc.ConnectingUserName, socket);

                    userNameCourant = uc.ConnectingUserName;
                };
            });
        }
    
    public static string Serialize(CartDeTour cartTour)
    {
        return Json.Encode(cartTour);
    }

    public static UserConnection Deserialize(string message)
    {
        return Json.Decode<UserConnection>(message);
    }
        public static void SendCartTour(CartDeTour cartJou)
        {

            List<IWebSocketConnection> allSockets = new List<IWebSocketConnection>();
            foreach (KeyValuePair<string, IWebSocketConnection> entry in ClientConnectedByUserName)
            {
                if (!entry.Key.Equals(cartJou.utilisateurUserName))
                {
                    allSockets.Add(entry.Value);
                }
            }



            server = new WebSocketServer("ws://0.0.0.0:8181");
            server.Start(socket =>
            {
                socket.OnOpen = () => allSockets.Add(socket);
                socket.OnClose = () => allSockets.Remove(socket);
                socket.OnMessage = message =>
                {
                    foreach (var s in allSockets.ToList())
                    {

                        s.Send(Serialize(cartJou));
                    }
                };
            });

        }
    }
}
public class CartDeTour
{
    public int cartId { get; set; }
    public string utilisateurUserName { get; set; }
}

public class UserConnection
{
    public string ConnectingUserName;
}