using System;
using System.Net;
using System.Windows.Forms;
using WheaterAPP.Models;
using Newtonsoft.Json;
using System.Linq;
using WheaterAPP.Forms;
using WheaterAPP.Service;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace WheaterAPP
{
    public partial class MainForm : Form
    {
        private WheaterInfoModel.root wheaterInfo;
        private FileService serviceJson;
        private double lon;
        private double lat;
        const string apiKey = "7c9001f16b5e53bc9763af9864fa18ee";

        public MainForm()
        {
            this.serviceJson = new FileService();

            InitializeComponent();

            SetShadow();
        }

        /// <summary>
        /// Ustawia cienie na wszystkich label, które wyświetlają informacje.
        /// </summary>
        private void SetShadow()
        {
            var controlList = this.Controls;

            List<Label> labelList = new List<Label>();

            foreach (var control in controlList)
            {
                if (control is Label)
                {
                    var label = control as Label;
                    if (!label.Name.Contains("lT"))
                    {
                        labelList.Add(label);
                    }
                }
            }
            var shadowColor = Color.FromArgb(100, Color.Black);

            foreach (var label in labelList)
            {
                label.BackColor = shadowColor;
            }
        }

        /// <summary>
        /// Wyświetla informacje o pogodzie dla danego miasta lub kraju.
        /// </summary>
        private void bt_Search_Click(object sender, EventArgs e)
        {
            GetWheater();

            {
                pB_Wheater.ImageLocation = "https://api.openweathermap.org/img/w/" + this.wheaterInfo.weather[0].icon + ".png";

                if (wheaterInfo.weather[0].description.Contains("ĹĽ"))
                {
                    l_DesValue.Text = wheaterInfo.weather[0].description.Replace("ĹĽ", "ż");
                }
                else
                {
                    l_DesValue.Text = wheaterInfo.weather[0].description.Replace("Ĺ‚", "ł");
                }

                l_TempValue.Text = Math.Floor(wheaterInfo.main.temp).ToString() + " °C";

                this.lon = wheaterInfo.coord.lon;
                this.lat = wheaterInfo.coord.lat;
                tB_Schearch.Text = wheaterInfo.name.ToUpper();

                b_MoreInfo.Visible = true;
                b_Forcast.Visible = true;
                b_Save.Visible = true;
                b_History.Visible = true;
            }
        }
            

        /// <summary>
        /// Pobiera prognoze pogody z dnia użycia aplikacji. 
        /// </summary>
        private void GetWheater()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q={tB_Schearch.Text}&units=metric&lang=pl&appid={apiKey}";

                    var json = webClient.DownloadString(url);

                    this.wheaterInfo = JsonConvert.DeserializeObject<WheaterInfoModel.root>(json);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Podano złą nazwe miasta lub wystapił inny błąd. \nSpróbuj ponownie.");
                new Exception($"Nie udało się pobrać informacji o pogodzie. \nBlad: {ex}");
            }
        }

        /// <summary>
        /// Wyświetla dodatkowe informacje o pogodzie z dnia użycia aplikacji. 
        /// </summary>
        private void b_MoreInfo_Click(object sender, EventArgs e)
        {
            var moreInfoForm = new MoreInfoForm(this.wheaterInfo);
            moreInfoForm.ShowDialog();
        }

        /// <summary>
        /// Wyświetla prognoze pogody na cztery następne dni.
        /// </summary>
        private void b_Forcast_Click(object sender, EventArgs e)
        {
            var forcastForm = new ForcastForm(this.lon, this.lat);
            forcastForm.ShowDialog();
        }

        /// <summary>
        /// Zapisuje prognoze pogody.
        /// </summary>
        private void bt_Save_Click(object sender, EventArgs e)
        {
            var filesList = serviceJson.GetHistoryFilesList();

            if (filesList.Any(x => Path.GetFileName(x).Contains(this.wheaterInfo.name) && Path.GetFileName(x).Contains(DateTime.Now.ToString("dd-MM-yyyy"))))
            {
                DialogResult historyExists = MessageBox.Show($"Isteniej już plik dla miasta {this.wheaterInfo.name} na dzień {DateTime.Now.ToString("dd-MM-yyyy")}. \n Czy chcesz go nadpisać?", "Decyzja", MessageBoxButtons.YesNo);

                if (historyExists == DialogResult.Yes)
                {
                    try
                    {
                        string fileToOverWritePath = filesList
                                                     .Where(x => Path.GetFileName(x).Contains(this.wheaterInfo.name)
                                                     && Path.GetFileName(x).Contains(DateTime.Now.ToString("dd-MM-yyyy")))
                                                     .FirstOrDefault();


                        serviceJson.OverWriteFile(fileToOverWritePath, this.wheaterInfo);

                        MessageBox.Show("Plik został nadpisany");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Coś poszło nie tak podczas próby nadpisania pliku.");
                    }

                }
                else
                {
                    return;
                }
            }
            else
            {
                try
                {
                    serviceJson.SerializeToJson(this.wheaterInfo);

                    MessageBox.Show($"Historia pogody dla miasta {this.wheaterInfo.name} na dzień {DateTime.Now.ToString("dd-MM-yyyy")} została zapisana.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie usało się zapisać histori pogody.");
                }
            }
        }

        /// <summary>
        /// Wyświetla tabele z zapisanymi prognozami pogody.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_History_Click(object sender, EventArgs e)
        {

            var jsonFiles = serviceJson.GetHistoryFilesList();

            if (jsonFiles.Count > 0)
            {

                var list = serviceJson.HistoryList(jsonFiles);

                var historyForm = new HistoryForm(list);

                historyForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie ma rzadnych plików z historią pogody.");
            }
        }
    }
}