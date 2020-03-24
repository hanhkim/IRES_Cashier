using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRES_Project.MoMo
{
    public class MoMoPayment
    {
        string endpointApp = "";
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// return 1: success, 0: khong action, -1: false
        /// </summary>
        /// <param name="totalpay"></param>
        /// <returns></returns>
        public int GoToMomoPayment(float totalpay, string billId)
        {
            try
            {
                string endpoint = endpointApp != "" ? endpointApp : "https://test-payment.momo.vn/gw_payment/transactionProcessor";
                string partnerCode = "MOMOCHGB20200212";
                string accessKey = "cPdPFP0OLjDRtz1P";
                string secretKey = "WdxZhXuftD0GIZB64kn7LCj8yIqbnJAd";
                string orderInfo = "Thanh toán hóa đơn Ires";
                string returnUrl = "https://momo.vn/";
                string notifyUrl = "https://momo.vn/notify";

                //string amount = totalpay.ToString();
                string amount = "535000";
                //string billId = "BILL_" + DateTime.Now.ToString("yyyyMMddHHmmssffff");
                string requestId = Guid.NewGuid().ToString();
                string extraData = "";

                // Before sign HMAC SHA256 signature
                string rawHash = "partnerCode=" +
                    partnerCode + "&accessKey=" +
                    accessKey + "&requestId=" +
                    requestId + "&amount=" +
                    amount + "&orderId=" +
                    billId + "&orderInfo=" +
                    orderInfo + "&returnUrl=" +
                    returnUrl + "&notifyUrl=" + notifyUrl + "&extraData=" + extraData;

                MoMoSecurity crypto = new MoMoSecurity();

                // sign signature SHA256
                string signature = crypto.signSHA256(rawHash, secretKey);

                // Build body json request
                JObject message = new JObject
                {
                    { "partnerCode", partnerCode },
                    { "accessKey", accessKey },
                    { "requestId", requestId },
                    { "amount", amount },
                    { "orderId", billId },
                    { "orderInfo", orderInfo },
                    { "returnUrl", returnUrl },
                    { "notifyUrl", notifyUrl },
                    { "extraData", extraData },
                    { "requestType", "captureMoMoWallet" },
                    { "signature", signature }
                };

                string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());

                JObject jmessage = JObject.Parse(responseFromMomo);

                System.Diagnostics.Process.Start(jmessage.GetValue("payUrl").ToString());
                DialogResult result1 = System.Windows.Forms.MessageBox.Show("Thanh toán thành công? ", "Kết quả Thanh toán", MessageBoxButtons.OKCancel);

                if (result1 == DialogResult.OK)
                {
                    // thanh toán thành công
                    return 1;
                }
                else if (result1 == DialogResult.Cancel)
                {
                    // thanh toán thất bại
                    return -1;
                }

                return 1;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Kết nối MoMo thất bại! Bạn có muốn thử lại!");

                return -1;
            }

        }
    }
}
