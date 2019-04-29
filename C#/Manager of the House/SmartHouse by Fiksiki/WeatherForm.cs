using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Objects.Objects.Weathers;

namespace SmartHouse_by_Fiksiki
{
    public partial class WeatherForm : UserControl
    {
        public Weather weather;
        public WeatherForm(Weather weather)
        {
            this.weather = weather;
            InitializeComponent();
        }

        
        private void butCreateWeather_Click(object sender, EventArgs e)
        {
            panelForDiscoverWeather.Visible = false;
            panelForCreateWeatherNow.Visible = true;
            labelSave.Visible = false;
        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            
            panelForDiscoverWeather.Visible = false;
            
            
            panelForCreateWeatherNow.Visible = false;
        }

        private void butRandWeather_Click(object sender, EventArgs e)
        {
            
            Random x = new Random();
            string[] str1 = { "Лето", "Осень", "Зима", "Весна" };
            string[] str2 = { "День", "Ночь" };
            string[] str3 = { "Снег", "Град", "Иней", "Туман", "Дождь", "Роса", "none" };
            weather.SetTimeOfDay(str2[x.Next(0, 2)]);

            weather.SetCloudiness(x.Next(0, 10));

            weather.SetSeason(str1[x.Next(0, 4)]);
            

            if (weather.GetSeason() == "Лето")
            {
                weather.SetDeposits(str3[x.Next(2, 7)]);
            }

            if (weather.GetSeason() == "Лето")
            {
                if (weather.GetTimeOfDay() == "День")
                    weather.SetTemp(x.Next(17, 32));
                else
                    weather.SetTemp(x.Next(15, 19));
            }
            else if (weather.GetSeason() == "Осень")
            {
                if (weather.GetTimeOfDay() == "День")
                    weather.SetTemp(x.Next(10, 20));
                else
                    weather.SetTemp(x.Next(5, 10));
            }
            else if (weather.GetSeason() == "Зима")
            {
                if (weather.GetTimeOfDay() == "День")
                    weather.SetTemp(x.Next(-7, 2));
                else
                    weather.SetTemp(x.Next(-17, -5));
            }
            else if (weather.GetSeason() == "Весна")
            {
                if (weather.GetTimeOfDay() == "День")
                    weather.SetTemp(x.Next(10, 21));
                else
                    weather.SetTemp(x.Next(5, 10));
            }
        }

        private void butDiscoverWeather_Click(object sender, EventArgs e)
        {
            panelForCreateWeatherNow.Visible = false;
            if (weather.GetTimeOfDay() == "Ночь")
            {
                if (weather.GetDeposits() == "Дождь" && weather.GetCloudiness() > 7)
                {
                    pictureBoxWeatherNow.BackgroundImage = Properties.Resources.nightStorm;
                }
                else if (weather.GetDeposits() == "Снег" || weather.GetDeposits() == "Град")
                {
                    pictureBoxWeatherNow.BackgroundImage = Properties.Resources.nightWinter;
                }
                else if (weather.GetCloudiness() > 4 || weather.GetDeposits() == "Туман")
                {
                    pictureBoxWeatherNow.BackgroundImage = Properties.Resources.nightCloud;
                }
                else if (weather.GetDeposits() == "Дождь")
                {
                    pictureBoxWeatherNow.BackgroundImage = Properties.Resources.nightRain;
                }
                else
                {
                    pictureBoxWeatherNow.BackgroundImage = Properties.Resources.nightSummer;
                }
            }
            else
            {
                if (weather.GetDeposits() == "Снег" || weather.GetDeposits() == "Град")
                {
                    pictureBoxWeatherNow.BackgroundImage = Properties.Resources.winter;
                }
                else if (weather.GetDeposits() == "Дождь" && weather.GetCloudiness() > 7)
                {
                    pictureBoxWeatherNow.BackgroundImage = Properties.Resources.storm;
                }
                else if (weather.GetCloudiness() > 4 || weather.GetDeposits() == "Туман")
                {
                    pictureBoxWeatherNow.BackgroundImage = Properties.Resources.cloud;
                }
                else if (weather.GetDeposits() == "Дождь")
                {
                    pictureBoxWeatherNow.BackgroundImage = Properties.Resources.rain;
                }
                else
                {
                    pictureBoxWeatherNow.BackgroundImage = Properties.Resources.summer;
                }
            }
            labelTemp.Text = (weather.GetTemp()).ToString() + "°";
            labelGetSeason.Text = weather.GetSeason();
            labelGetDiposites.Text = weather.GetDeposits();
            labelGetTimeDay.Text = weather.GetTimeOfDay();
            labelGetCloud.Text = (weather.GetCloudiness()).ToString();
            panelForDiscoverWeather.Visible = true;
        }

        private void butOk_Click(object sender, EventArgs e) 
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBoxCloudiness.Text) || string.IsNullOrEmpty(comboBoxDeposits.Text))
            {
                MessageBox.Show("Не все поля заполнены.");
                return;
            }
            for (int i = 0; i < 4; i++)
            {
                if (((RadioButton)panelForSelectSeason.Controls[i]).Checked)
                {
                    weather.SetSeason(((RadioButton)panelForSelectSeason.Controls[i]).Text);
                }
            }
            weather.SetTemp(int.Parse(textBox1.Text));
            weather.SetDeposits(comboBoxDeposits.Text);
            for (int i = 0; i < 2; i++)
            {
                if (((RadioButton)panelForSelectDay.Controls[i]).Checked)
                {
                    weather.SetTimeOfDay(((RadioButton)panelForSelectDay.Controls[i]).Text);
                }
            }
            weather.SetCloudiness(int.Parse(comboBoxCloudiness.Text));
            labelSave.Visible = true;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 45 && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
