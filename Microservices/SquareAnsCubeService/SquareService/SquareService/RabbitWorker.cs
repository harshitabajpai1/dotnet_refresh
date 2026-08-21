using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace SquareService
{
    public class RabbitWorker : BackgroundService
    {
        //windows service that listens to RabbitMQ messages, calculates the square of the number, and sends the result back to another queue
        //windows service is bacckground service that runs in the background and does not have a user interface
        //it wacthes the "number_queue" for messages, and when it receives a message, it calculates the square of the number and sends the result back to the "square_queue"

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            var connection = await factory.CreateConnectionAsync();
            var channel = await connection.CreateChannelAsync();

            //where to read
            await channel.QueueDeclareAsync(
                queue: "number_queue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);
            //where to write
            await channel.QueueDeclareAsync(
                queue: "square_queue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            Console.WriteLine("SquareService waiting for messages...");

            var consumer = new AsyncEventingBasicConsumer(channel);
            //event handler for when a message is received
            //event handler is asynchronous because we want to be able to process multiple messages at the same time
            //event driven programming is a programming paradigm in which the flow of the program is determined by events, such as user input or messages from other services
            consumer.ReceivedAsync += async (sender, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                int number = int.Parse(message);
                int square = number * number;

                Console.WriteLine($"Square calculated: {square}");

                var newBody = Encoding.UTF8.GetBytes(square.ToString());

                await channel.BasicPublishAsync(
                    exchange: "",
                    routingKey: "square_queue",
                    body: newBody);

                await Task.CompletedTask;
            };

            await channel.BasicConsumeAsync(
                queue: "number_queue",
                autoAck: true,
                consumer: consumer);
        }
    }
}