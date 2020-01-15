using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using IRES_Project.Cashier.MainPage;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ViewModel.Cashier.Common;
using IRES_Project.Views;

namespace IRES_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public MainWindow()
        {

            InitializeComponent();
            //ReceiveNotifyRabbitMQ rabbitMQConnection = new ReceiveNotifyRabbitMQ();

            //Login to enter main page
          //  Login loginWindow = new Login();
          //  loginWindow.ShowDialog();

            // listening notify
            ReceiveNotifyRabbitMQ();

            Switcher.pageSwitcher = this;
            Switcher.Switch(new TablePage());
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public void ReceiveNotifyRabbitMQ()
        {
            try
            {
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

                    if (message != null)
                    {
                        if (BreadCrumbViewModel.Instance.BreadCrumb.Last() == "Table")
                        {
                            Application.Current.Dispatcher.Invoke((Action)delegate {
                                Switcher.Switch(new TablePage());
                            });
                        }
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
