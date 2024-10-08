using System;

namespace WebChat.Models
{
    public class UserConnection
    {
        // Adicionando um identificador �nico para o usu�rio
        public string UserId { get; set; } = Guid.NewGuid().ToString(); // Gerando um novo GUID como ID �nico

        public string UserName { get; set; } = string.Empty;
        public string ChatRoom { get; set; } = string.Empty;

        // Voc� pode adicionar mais propriedades, como:
        public DateTime ConnectedAt { get; set; } = DateTime.UtcNow; // Data e hora de conex�o
    }
}
