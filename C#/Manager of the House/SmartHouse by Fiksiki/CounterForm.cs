using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Objects.Objects.Devices;
using BL.Objects.Objects.Houses;

namespace SmartHouse_by_Fiksiki
{
    public partial class CounterForm : UserControl
    {

        House house;
        public ListViewItem item;
        public CounterForm(House house)
        {
            this.house = house;
            InitializeComponent();
        }

        private void CounterForm_Load(object sender, EventArgs e)
        {
            pictureBoxElect.Visible = false;
            pictureBoxWater.Visible = false;
            pictureBoxGas.Visible = false;
            LoadListOnDevices();


        }

        public void LoadListOnDevices()
        {
            listViewDevOn.Items.Clear();
            foreach (var room in house.Rooms)
            {
                foreach (var device in room.Devices)
                {
                    if (device.StatusOfDevice)
                    {
                        item = new ListViewItem(device.NameOfDevice);
                        listViewDevOn.Items.Add(item);
                        item.SubItems.Add(room.Name);
                    }
                }
            }
        }

        public async void countCharge(ApplianceType a, Label b)
        {
            while (true)
            {
                
                foreach (var room in house.Rooms)
                {
                    foreach (var device in room.Devices)
                    {
                        if (device.StatusOfDevice && device.Type == a)
                        {
                            device.Toggle();
                            device.Toggle();
                        }
                    }
                }

                b.Text = house.GetAllConsuption(a).ToString();
                await Delay();
            }
        }
        private async Task Delay()
        {
            await Task.Delay(1000);
        }

        bool startCheckFunctionForWater = true,
            startCheckFunctionForGas = true,
            startCheckFunctionForElect = true;
        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBoxGas.Visible = false;
            pictureBoxElect.Visible = false;
            pictureBoxWater.Visible = true;
            lbCountGas.Visible = false;
            lbCountElect.Visible = false;
            lbCountWater.Visible = true;
            if(startCheckFunctionForWater)
                countCharge(ApplianceType.Water, lbCountWater);
            startCheckFunctionForWater = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadListOnDevices();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxGas.Visible = false;
            pictureBoxWater.Visible = false;
            pictureBoxElect.Visible = true;
            lbCountGas.Visible = false;
            lbCountWater.Visible = false;
            lbCountElect.Visible = true;
            if (startCheckFunctionForElect)
                countCharge(ApplianceType.Electrical, lbCountElect);
            startCheckFunctionForElect = false; 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBoxElect.Visible = false;
            pictureBoxWater.Visible = false;
            pictureBoxGas.Visible = true;
            lbCountElect.Visible = false;
            lbCountWater.Visible = false;
            lbCountGas.Visible = true;
            if (startCheckFunctionForGas)
                countCharge(ApplianceType.Gas, lbCountGas);
            startCheckFunctionForGas = false;
        }
    }
}
