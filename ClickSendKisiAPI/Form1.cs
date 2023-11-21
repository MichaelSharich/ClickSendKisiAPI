using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.ClickSend.Model;
using IO.ClickSend.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickSendKisiAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeHttpClient();
            InitializeClickSend();
        }

        SMSApi SMSAPI;
        HttpClient HClient;

        public void InitializeHttpClient()
        {
            HClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.kisi.io//")
            };

            HClient.DefaultRequestHeaders.Add("Authorization", "Basic " + "Kisi_API_Key");
            HClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
        }

        public void InitializeClickSend()
        {
            Configuration config = new Configuration();
            config.Username = "clicksend@clicksend.com";
            config.AddApiKey("0", "2F19C229-6167-9AFD-22C0-8222222222");

            SMSAPI = new SMSApi(config);


        }

        public async void GetAsyncEvents(HttpClient InClient)
        {
            //Get events response from Kisi
            HttpResponseMessage response = await InClient.GetAsync("events");

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            LB_Events.Items.Add(jsonResponse);
        }

        private void btn_GetEvents_Click(object sender, EventArgs e)
        {
            GetAsyncEvents(HClient);
        }

        private void SendClickSendSMS()
        {
            //Example of sending SMS from ClickSend
            var listOfSMS = new List<SmsMessage>
            {
                new SmsMessage(
                    to: "Test",
                    body: "Test Message",
                    from: "",
                    source: "sdk",
                    schedule: 0
                    )
            };

            var SMSCollesction = new SmsMessageCollection(listOfSMS);
            string response = SMSAPI.SmsSendPost(SMSCollesction);
        }
    }
}
