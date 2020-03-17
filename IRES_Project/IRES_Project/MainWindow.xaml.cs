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
using System.Media;
using WMPLib;
using System.IO;
using Newtonsoft.Json.Linq;
using IRES_Project.MoMo;
using ViewModel.Cashier.Modules;

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

            //SoundPlayer sound1 = new SoundPlayer("../../Resources/musics/when.wav");
            //sound1.Play();

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
                //exchange test
                //var queueName = channel.QueueDeclare("khanhs").QueueName;
                //channel.QueueBind(queue: queueName, exchange: "directExchange", routingKey: "COOK1");


                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);

                    if (message != null)
                    {
                        try
                        {
                            SoundPlayer sound = new SoundPlayer("../../Resources/musics/when.wav");
                            sound.Play();
                        }
                        catch (Exception e)
                        {
                           // MessageBox.Show("beep sound error!!");
                        }

                        InfoNotifyModel infoNotify = getInfoNotify(message);

                        if (infoNotify.typeMessage != null && infoNotify.descriptionMessage != null && infoNotify.descriptionMessage.Contains("Thanh toán")) // them hinh thuc thanh toan o day
                        {
                            MessageBox.Show(infoNotify.descriptionMessage);
                           //GotoMomopayment(infoNotify);
                        }
                        else
                        {
                            MessageBox.Show(infoNotify.descriptionMessage);
                        }

                        if (BreadCrumbViewModel.Instance.BreadCrumb.Last() == "Bàn")
                        {
                            Application.Current.Dispatcher.Invoke((Action)delegate {
                                Switcher.Switch(new TablePage());
                            });
                        }
                    }
                };
                channel.BasicConsume(queue: "cashier_queue",
                                     autoAck: true,
                                     consumer: consumer);



                //channel.BasicConsume(queue: queueName,
                //                     autoAck: true,
                //                     consumer: consumer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Lỗi kết nối Rabbitmq");
            }
        }

        public InfoNotifyModel getInfoNotify(string message)
        {
            InfoNotifyModel result = new InfoNotifyModel();

            JObject jMessage = JObject.Parse(message);
            string textMessage = jMessage.SelectToken("text").ToString();
            JObject jDataMessage = JObject.Parse(textMessage);
            string Data = jDataMessage.SelectToken("data").ToString();

            JObject jData = JObject.Parse(Data);
            result.receiver = jData.SelectToken("receiver").ToString();
            result.descriptionMessage = jData.SelectToken("description").ToString();
            result.typeMessage = jData.SelectToken("type").ToString();

            return result;
        }

        //public void GotoMomopayment(InfoNotifyModel infoNotifyModel)
        //{
        //    MoMoPayment momoRequest = new MoMoPayment();

        //    BillViewModel billVM = new BillViewModel(Convert.ToInt32(infoNotifyModel.receiver));
        //    string billId = "BILL_" + DateTime.Now.ToString("yyyyMMddHHmmssffff");
        //    int result = momoRequest.GoToMomoPayment(billVM.MoneyDetail.TotalPay, billId);

        //    if (result == 1) // thanh toan thanh cong
        //    {
        //       // GoToPayment("momo", billId);
        //    }
        //    else if (result == -1) // thanh toan that bai
        //    {
        //        System.Windows.MessageBox.Show("Thanh toan momo that bai, vui long kiem tra lai");
        //    }
        //    else if (result == 0) // khong bat browser
        //    {

        //    }
        //}
    }

    public partial class InfoNotifyModel
    {
        public InfoNotifyModel()
        {

        }
        public string receiver;
        public string descriptionMessage;
        public string typeMessage;
    }
}
