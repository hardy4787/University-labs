using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Objects;
using BL.Objects.Objects.Devices;
using BL.Objects.Objects.Houses;
using BL.Objects.Objects.Rooms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace SmartHouse_by_Fiksiki
{
    public partial class Form1 : Form
    {
        Visitor vis = new Visitor();
        public Form1()
        {
            InitializeComponent();
            Application.ThreadExit += SaveDataInFile;

        }
        public House house;
        public void SaveDataInFile(object sender, EventArgs e)
        {
            //string Path = "D:/" + vis.Login + ".json";
            DataContractJsonSerializer Json = new DataContractJsonSerializer(typeof(House));
            using (FileStream Fs = new FileStream("../../../kek.json", FileMode.Create))
            { Json.WriteObject(Fs, house); }
        }
        public void LoadFromFile(object sender, EventArgs e)
        {
            //string Path = "D:/" + vis.Login + ".json";
            //if (!File.Exists(Path))
            //{
            //    MessageBox.Show("Такого пользователя не существует");
            //    return;
            //}
            DataContractJsonSerializer Json = new DataContractJsonSerializer(typeof(House));
            using (FileStream Fs = new FileStream("../../../kek.json", FileMode.Open))
            { house = (House)Json.ReadObject(Fs); }
           
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            SaveDataInFile(sender, e);
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelAuthorization.Visible = false;
            house = new House(name: "House", rooms:
                new List<Room>() {
                    new Room(name: "Кухня", devices: new List<DeviceBase>()),
                    new Room(name: "Ванна", devices: new List<DeviceBase>()),
                    new Room(name: "Спальня", devices: new List<DeviceBase>()),
                    new Room(name: "Гостинная", devices: new List<DeviceBase>())
                }
            );
        }
        
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);
            //vis.Login = textBox1.Text;
            //vis.Password = textBox2.Text;
            LoadFromFile(sender, e);
            FormMenu form3 = new FormMenu(house);
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            panelAuthorization.Visible = true;
            textBox3.Select();
        }
    }
}
