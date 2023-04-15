using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

internal class Program
{
    private static void Main(string[] args)
    {
        ConnectionFactory factory = new ConnectionFactory();
        factory.Uri = new Uri("http://localhost:15672/");
        factory.HostName = "localhost";

        using (IConnection connection = factory.CreateConnection())
        using (IModel channel = connection.CreateModel())
        {
            channel.QueueDeclare("mesajkuyrugu", false, false, true);
            byte[] bytemessage = Encoding.UTF8.GetBytes("sevdim seni 1 kere");
            channel.BasicPublish(exchange: "", routingKey: "mesajkuyrugu", body: bytemessage);
        }
        Console.Read();
    }
}