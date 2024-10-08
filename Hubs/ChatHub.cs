using Microsoft.AspNetCore.SignalR;
using WebChat.DataService;
using WebChat.Models;

namespace WebChat.Hubs
{
    public class ChatHub : Hub
    {
        private readonly InMemoryDb _db;

        public ChatHub(InMemoryDb db){
            _db = db;
        }

        public async Task JoinChat(UserConnection conn)
        {
            await Clients.All.SendAsync("ReceiveMessage","admin",$"{conn.UserName} entrou ","");
        }

        public async Task JoinSpecifChat(UserConnection conn){
        
            await Groups.AddToGroupAsync(Context.ConnectionId,conn.ChatRoom);

            //adicionando o user no banco em memoria
            _db.connections[Context.ConnectionId] = conn;

            await Clients.Group(conn.ChatRoom)
                .SendAsync("JoinSpecifChat","admin",$"{conn.UserName} entrou no chat",$"{conn.ChatRoom}");
        }
        
        
        public async Task SendMessage(string msg)
        {
            if(_db.connections.TryGetValue(Context.ConnectionId,out UserConnection conn))
            {
                await Clients.Group(conn.ChatRoom)
                .SendAsync("ReceiveSpecificMessage",conn.UserName,msg);
            }
        }
    }
}