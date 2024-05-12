using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using WheaterAPP.Models;

namespace WheaterAPP.Forms
{
    public partial class ForcastForm : Form
    {
        const string apiKey = "7c9001f16b5e53bc9763af9864fa18ee";
        private double lon;
        private double lat;

        private WheaterForcastModel.WheaterForcast forcastsList;

        public ForcastForm(double lon, double lat) : this()
        {
            this.lon = lon;
            this.lat = lat;
            SetShadow();
            GetForcast();
            SetDate();
        }


        public ForcastForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Ustawia cienie na wszystkich label, które wyświetlają informacje.
        /// </summary>
        private void SetShadow()
        {
            var controlList = this.Controls;

            List<FlowLayoutPanel> flowList = new List<FlowLayoutPanel>();

            foreach (var control in controlList)
            {
                if (control is FlowLayoutPanel)
                {
                    flowList.Add(control as FlowLayoutPanel);
                }
            }
            var shadowColor = Color.FromArgb(150, Color.Black);

            foreach (var flow in flowList)
            {
                flow.BackColor = shadowColor;
            }
        }


        /// <summary>
        /// Pobiera informacje o pogodzie na następne cztery dni z darmowego API.
        /// </summary>
        private void GetForcast()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    string url = $"https://api.openweathermap.org/data/2.5/forecast?lat={this.lat}&lon={this.lon}&appid={apiKey}&units=metric&lang=pl";
                    ;
                    var json = webClient.DownloadString(url);

                    var results = JsonConvert.DeserializeObject<WheaterForcastModel.WheaterForcast>(json);

                    var newForcast = new WheaterForcastModel.WheaterForcast();

                    newForcast.city = results.city;

                    newForcast.list = results.list
                                     .Where(x => DateTime.Parse(x.dt_txt).Date > DateTime.Now.Date)
                                     .GroupBy(x => DateTime.Parse(x.dt_txt).Date)
                                     .Select(group => group.Where(y => DateTime.Parse(y.dt_txt).Hour == 12).FirstOrDefault())
                                     .ToList();

                    this.forcastsList = newForcast;
                }

            }
            catch (Exception ex)
            {
                new Exception($"Nie udało się pobrać informacji o pogodzie. \nBlad: {ex}");
            }
        }

        /// <summary>
        /// Ustawia informacje o pogodzie na form.
        /// </summary>
        private void SetDate()
        {
            try
            {
                List<System.Windows.Forms.Label> labelsDate = new List<System.Windows.Forms.Label> 
                { 
                    l_Date1,
                    l_Date2,
                    l_Date3,
                    l_Date4
                };

                List<System.Windows.Forms.Label> labelsTemp = new List<System.Windows.Forms.Label> 
                {
                    l_Temp1,
                    l_Temp2,
                    l_Temp3,
                    l_Temp4
                };

                List<PictureBox> pictureBoxes = new List<PictureBox> 
                { 
                    pB_WheaterIcon1,
                    pB_WheaterIcon2,
                    pB_WheaterIcon3,
                    pB_WheaterIcon4
                };

                var i = 0;
                foreach(var forcast in this.forcastsList.list)
                {
                    pictureBoxes[i].ImageLocation = "https://api.openweathermap.org/img/w/" + forcast.weather[0].icon + ".png";
                    labelsDate[i].Text = (DateTime.Parse(forcast.dt_txt).Date).ToString("dd-MM-yy");
                    labelsTemp[i].Text = $"{Math.Floor(forcast.main.temp)}  °C";
                    i++;
                }
            }
            catch (Exception ex)
            {
                new Exception($"Nie udało się wprowazić informacji o pogodzie. \nBlad: {ex}");
            }
        }

        /// <summary>
        /// Wyświetla więcej informacji o danym dniu.
        /// </summary>
        private void MoreForcastInfo(object sender, EventArgs e)
        {
            try
            {
                var flowPanel = (FlowLayoutPanel)sender;

                var flowName = flowPanel.Name.ToString();

                var dayNumber = int.Parse(flowName.Last().ToString()) - 1;

                var dayInfo = this.forcastsList.list[dayNumber];

                var moreDayInfo = new WheaterInfoModel.root();

                moreDayInfo.main = new WheaterInfoModel.main();
                moreDayInfo.main.pressure = dayInfo.main.pressure;  
                moreDayInfo.main.humidity = dayInfo.main.humidity;

                moreDayInfo.wind = new WheaterInfoModel.wind();
                moreDayInfo.wind.speed = dayInfo.wind.speed;

                moreDayInfo.sys = new WheaterInfoModel.sys();
                moreDayInfo.sys.sunset = this.forcastsList.city.sunset;
                moreDayInfo.sys.sunrise = this.forcastsList.city.sunrise;

                
                var moreForcastInfoForm = new MoreInfoForm(moreDayInfo);
                moreForcastInfoForm.ShowDialog();
            }
            catch (Exception ex)
            {
                new Exception($"Nie udało się wprowadzić informacji o pogodzie . \nBlad: {ex}");
            }

        }

    }
}   
