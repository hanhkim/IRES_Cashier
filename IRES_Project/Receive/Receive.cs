using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Receive
{
    class Program
    {
        public static void Main()
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();
                factory.UserName = "xarzdlrm";
                factory.Password = "Be9K-7C4C1sO9hiJTJwZSHITqm7NX6LS";
                factory.VirtualHost = "xarzdlrm";
                //factory.Protocol = Protocols.FromEnvironment();
                factory.HostName = "baboon.rmq.cloudamqp.com";
                //factory.Port = AmqpTcpEndpoint.UseDefaultPort;
                IConnection conn = factory.CreateConnection();

                var channel = conn.CreateModel();

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" [x] Received {0}", message);
                };
                channel.BasicConsume(queue: "local.notification.order.trigger-handler.queue",
                                     autoAck: true,
                                     consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Loi roai");
            }
        }
    }
}
