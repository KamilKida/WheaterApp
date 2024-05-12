using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheaterAPP.Models;

namespace WheaterAPP.Forms
{
    public partial class ShowHistoryForm : Form
    {
        private WheaterInfoModel.root hiostoryInfo;
        public ShowHistoryForm(WheaterInfoModel.root historyInfo) : this()
        {
            this.hiostoryInfo = historyInfo;
            SetHistoryInfo();
            SetShadow();
        }
        public ShowHistoryForm()
        {
            InitializeComponent();
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
        /// Ustawia informacje pogodowe dla danego dnia w form.
        /// </summary>
        private void SetHistoryInfo()
        {
            pB_Wheater.ImageLocation = "https://api.openweathermap.org/img/w/" + this.hiostoryInfo.weather[0].icon + ".png";

            if (hiostoryInfo.weather[0].description.Contains("ĹĽ"))
            {
                l_DesValue.Text = hiostoryInfo.weather[0].description.Replace("ĹĽ", "ż");
            }
            else
            {
                l_DesValue.Text = hiostoryInfo.weather[0].description.Replace("Ĺ‚", "ł");
            }

            l_TempValue.Text = Math.Floor(hiostoryInfo.main.temp).ToString() + " °C";

            lT_City.Text = hiostoryInfo.name.ToUpper();

            l_Sunrise.Text = ConvertDate(hiostoryInfo.sys.sunrise).ToString("HH:mm");
            l_Sunset.Text = ConvertDate(hiostoryInfo.sys.sunset).ToString("HH:mm");

            l_WindSpped.Text = Math.Floor(hiostoryInfo.wind.speed).ToString() + " KM\\h";

            l_Presure.Text = Math.Floor(hiostoryInfo.main.pressure).ToString() + " hPa";
            l_Humidity.Text = hiostoryInfo.main.humidity.ToString() + " %";
        }

        /// <summary>
        /// Wyswietla datę w odpowiedniej formie.
        /// </summary>
        /// <param name="miliseconds">Milisekundy do zmiany na datę. </param>
        /// <returns>Datę</returns>
        private DateTime ConvertDate(string miliseconds)
        {
            try
            {
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();

                day = day.AddSeconds(long.Parse(miliseconds)).ToLocalTime();

                return day;
            }
            catch (Exception ex)
            {
                throw new Exception($"Nie udało się przekonwertować daty. \nBłąd: {ex}");
            }
        }
    }
}
