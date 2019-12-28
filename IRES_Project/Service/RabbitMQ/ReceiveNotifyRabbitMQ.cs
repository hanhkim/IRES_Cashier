using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.RabbitMQ
{
    public class ReceiveNotifyRabbitMQ
    {
        public ReceiveNotifyRabbitMQ()
        {
            try
            {
                MessageBox.Show("rabbitmq");
                ConnectionFactory factory = new ConnectionFactory();
                factory.UserName = "xarzdlrm";
                factory.Password = "Be9K-7C4C1sO9hiJTJwZSHITqm7NX6LS";
                factory.VirtualHost = "xarzdlrm";
                factory.HostName = "baboon.rmq.cloudamqp.com";
                IConnection conn = factory.CreateConnection();

                var channel = conn.CreateModel();

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    //MessageBox.Show(" [x] Received {0}", message);
                    //Console.WriteLine(" [x] Received {0}", message);
                    if (message != null )
                    {
                        //string currentPage = IRES_Globals.Cashier.BreadCrumb..Last();
                        //if (currentPage != null && currentPage == "Table")
                        //{
                        //    // action load table 
                              
                        //}
                    }
                };
                channel.BasicConsume(queue: "local.notification.order.trigger-handler.queue",
                                     autoAck: true,
                                     consumer: consumer);

            }
            catch
            {
                MessageBox.Show("Loi roai");
            }
        }
    }
}
