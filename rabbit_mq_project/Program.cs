using RabbitMQ.Client;

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new Uri("http://localhost:15672/");
factory.HostName = "localhost";

