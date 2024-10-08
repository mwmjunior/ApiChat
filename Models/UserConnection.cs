using System;

namespace WebChat.Models
{
    public class UserConnection
    {
        // Adicionando um identificador único para o usuário
        public string UserId { get; set; } = Guid.NewGuid().ToString(); // Gerando um novo GUID como ID único

        public string UserName { get; set; } = string.Empty;
        public string ChatRoom { get; set; } = string.Empty;

        // Você pode adicionar mais propriedades, como:
        public DateTime ConnectedAt { get; set; } = DateTime.UtcNow; // Data e hora de conexão
    }
}
