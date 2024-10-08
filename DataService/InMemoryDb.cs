using System.Collections.Concurrent;
using WebChat.Models;

namespace WebChat.DataService
{
    public class InMemoryDb
    {
        private readonly ConcurrentDictionary<string,UserConnection> _connections = new ();

        public ConcurrentDictionary<string,UserConnection> connections => _connections;
    }
}