using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebChat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebChatController : ControllerBase
    {
        // Endpoint para verificar o status da API
        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            return Ok(new { message = "WebChat API is running" });
        }

        // Endpoint para enviar uma mensagem (simulando uma integração de chat)
        [HttpPost("send-message")]
        public IActionResult SendMessage([FromBody] ChatMessage message)
        {
            if (message == null || string.IsNullOrEmpty(message.UserName) || string.IsNullOrEmpty(message.Content))
            {
                return BadRequest("Invalid message data.");
            }

            // Simulando o envio de mensagem (você pode integrar com a lógica do SignalR aqui)
            return Ok(new { message = "Message sent successfully", data = message });
        }
    }

    // Classe para representar a mensagem do chat
    public class ChatMessage
    {
        public string UserName { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
