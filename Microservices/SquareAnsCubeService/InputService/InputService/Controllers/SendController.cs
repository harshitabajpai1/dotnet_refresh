using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text;

namespace ProducerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendController : ControllerBase
    {
        [HttpGet]
        //connection -> channel -> queue -> message
        //rabbitmq knows only bytes, so we need to convert our message to bytes
        //Producer → Convert data to byte[] → RabbitMQ Queue → Consumer → Convert byte[] back to data
        public async Task<string> SendNumber(int number)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            await using var connection = await factory.CreateConnectionAsync();
            await using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(
                queue: "number_queue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            var message = number.ToString();
            var body = Encoding.UTF8.GetBytes(message);

            await channel.BasicPublishAsync(
                exchange: "",
                routingKey: "number_queue",
                body: body);

            return $"Number {number} sent to RabbitMQ!";
        }
    }
}