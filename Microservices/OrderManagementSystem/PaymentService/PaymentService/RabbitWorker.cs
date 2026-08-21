using Microsoft.AspNetCore.Connections;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace PaymentService
{
    public class RabbitWorker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            var connection = await factory.CreateConnectionAsync();
            var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(
                queue: "amount_queue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            await channel.QueueDeclareAsync(
                queue: "payment_queue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            Console.WriteLine("Payment Service Initiated...");

            var consumer = new AsyncEventingBasicConsumer(channel);

            consumer.ReceivedAsync += async (sender, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                int number = int.Parse(message);


                Console.WriteLine($"Payment Done:- {number}");

                var newBody = Encoding.UTF8.GetBytes(number.ToString());

                await channel.BasicPublishAsync(
                    exchange: "",
                    routingKey: "payment_queue",
                    body: newBody);

                await Task.CompletedTask;
            };

            await channel.BasicConsumeAsync(
                queue: "amount_queue",
                autoAck: true,
                consumer: consumer);
        }
    }
}