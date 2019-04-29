using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Objects.Objects.Devices;
using BL.Objects.Objects.Houses;
using BL.Objects.Objects.Rooms;
using BL.Objects.Objects.Weathers;

namespace SmartHouse_by_Fiksiki
{
    public partial class FormMenu : Form
    {
        public Weather weather;
        public House house;
        WeatherForm Wf;
        HouseManage Hs;
        UtilitiesForm Uf;
        CounterForm Cf;

        public FormMenu(House house)
        {
            InitializeComponent();
            this.house = house;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            weather = new Weather();
        }

        

        private void butWeather_Click(object sender, EventArgs e)
        {
            if (Wf == null || Wf.IsDisposed)
            {
                Wf = new WeatherForm(weather);
                Wf.Show();
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(Wf);
        }
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void butHouseManage_Click(object sender, EventArgs e)
        {
            if (Hs == null || Hs.IsDisposed)
            {
                Hs = new HouseManage(house);
                Hs.Show();
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(Hs);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Uf = new UtilitiesForm(house);
            Uf.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(Uf);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Cf == null || Cf.IsDisposed)
            {
                Cf = new CounterForm(house);
            }
            Cf.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(Cf);
        }
    }
}
