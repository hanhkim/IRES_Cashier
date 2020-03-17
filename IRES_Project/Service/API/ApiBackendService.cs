using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public class ApiBackendService
    {
        public async Task<bool> SendApiToBackend(int id)
        {
            try
            {
                HttpClient client = new HttpClient();

                var url = $"http://" + IRES_Globals.GlobalClass.ConnectionInfo.SERVER + $":8081/cashier/payment/order/{id}";

                var response = await client.PostAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    //System.Windows.Forms.MessageBox.Show(response.Content.ToString());
                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Loi roi");
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
