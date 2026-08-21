using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendController : ControllerBase
    {
        [HttpGet]
        public async Task<string> Send(int amount)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            await using var connection = await factory.CreateConnectionAsync();
            await using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(
                queue: "amount_queue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            var message = amount.ToString();
            var body = Encoding.UTF8.GetBytes(message);

            await channel.BasicPublishAsync(
                exchange: "",
                routingKey: "amount_queue",
                body: body);

            return $"Payment Request {amount} rupees Sent..... waiting for payment to approve";
        }
    }
}
