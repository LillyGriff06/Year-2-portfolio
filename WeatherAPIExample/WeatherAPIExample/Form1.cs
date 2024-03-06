using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherAPIExample
{
    public partial class Form1 : Form
    {
        public string location { get; set; } = "Middlesbrough";

        public HttpClient httpClient { get; set; }

        //API key for the OpenWeather oraganisation APIs

        public string APIKey = "b1fe4659e300363e368f4ce2cf007fac";

        public async Task<List<float>> GetCoordinates(string region)

        {

            //Gets the latitude and longitude of the chosen location

            HttpResponseMessage response = await httpClient.GetAsync($"http://api.openweathermap.org/geo/1.0/direct?q={region}&limit=5&appid={APIKey}");

            string payload = await response.Content.ReadAsStringAsync();

            JArray payloadObject = JArray.Parse(payload);

            return new List<float>()

            {

                (float)payloadObject[0]["lat"],

                (float)payloadObject[0]["lon"]

            };

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<float> coordinates = await GetCoordinates(this.location);

            //Use the api to get some weather data

            HttpResponseMessage response = await httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?lat={coordinates[0]}&lon={coordinates[1]}&appid={APIKey}");

            string payload = await response.Content.ReadAsStringAsync();

            MessageBox.Show(payload);

            //Parse (read) the data itemds from the JSON object

            JObject payloadObject = JObject.Parse(payload);

            //Get individual items from the JSON object

            MessageBox.Show((string)payloadObject["weather"][0]["description"]);

            MessageBox.Show((string)payloadObject["main"]["temp"]);

            MessageBox.Show((string)payloadObject["visibility"]);

            MessageBox.Show((string)payloadObject.GetValue("main").ToString());

            MessageBox.Show((string)payloadObject.Count.ToString());

            MessageBox.Show((string)payloadObject.First.ToString());
        }

        public Form1()
        {
            InitializeComponent();

            //Creates a new form of the http client class.

            httpClient = new HttpClient();

            this.location = location;
        }
    }
}
