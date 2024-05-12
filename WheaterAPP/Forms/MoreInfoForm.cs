using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WheaterAPP.Models;

namespace WheaterAPP.Forms
{
    public partial class MoreInfoForm : Form
    {
        private WheaterInfoModel.root wheaterInfo;

        public MoreInfoForm(WheaterInfoModel.root wheaterInfo) : this()
        {
            this.wheaterInfo = wheaterInfo;
            LoadMoreInfo();
            SetShadow();
        }

        public MoreInfoForm()
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
        /// Wprowadza informacje dla dodatkowych informacji o pogodzie.
        /// </summary>
        private void LoadMoreInfo()
        {
            try
            {
                l_Sunrise.Text = ConvertDate(wheaterInfo.sys.sunrise).ToString("HH:mm");
                l_Sunset.Text = ConvertDate(wheaterInfo.sys.sunset).ToString("HH:mm");

                l_WindSpped.Text = Math.Floor(wheaterInfo.wind.speed).ToString() + " KM\\h";

                l_Presure.Text = Math.Floor(wheaterInfo.main.pressure).ToString() + " hPa";
                l_Humidity.Text = wheaterInfo.main.humidity.ToString() + " %";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coś poszło nie tak podczas próby wyświetlenia informacji. ");
                this.Close();
            }

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
            catch(Exception ex)
            {
                throw new Exception($"Nie udało się przekonwertować daty. \nBłąd: {ex}");
            }
        }
    }
}
