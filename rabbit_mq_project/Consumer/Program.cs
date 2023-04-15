using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://hkhjerrt:hcqiavAqll6-co4abXnSqUBh_hHifz-Z@hornet.rmq.cloudamqp.com/hkhjerrt");

            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare("iskuyrugu", durable: true, false, false, null);
                channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

                EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
                channel.BasicConsume("iskuyrugu", false, consumer);
                consumer.Received += (sender, e) =>
                {
                    Thread.Sleep(int.Parse(args[0]));
                    Console.WriteLine(Encoding.UTF8.GetString(e.Body) + " alındı");
                    channel.BasicAck(e.DeliveryTag, false);
                };
                Console.Read();
            }
        }
    }
}
