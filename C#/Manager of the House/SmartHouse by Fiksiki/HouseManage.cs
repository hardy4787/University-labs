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

namespace SmartHouse_by_Fiksiki
{
    public partial class HouseManage : UserControl
    {
        //int[] countDevice = new int[]{ 0, 0, 0, 0 }; // индекс девайса в каждой комнате
        int countRoom; // Индекс комнаты
        int indexItemListView; // индекс прибора (равен индексу выделенного элемента в listview
        public House house;
        public ListViewItem item;
        public HouseManage(House house)
        {
            this.house = house;
            InitializeComponent();
        }
        
        private void HouseManage_Load(object sender, EventArgs e)
        {
            cbTypeOfUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            panelRoomsDevices.Visible = false;
            panelAddNewDevice.Visible = false;
            panelChangeName.Visible = false;
            panelChangePowerDevice.Visible = false;

        }
        public void LoadListView()
        { 
            listView.Items.Clear();
            for (int i = 0; i < house.Rooms.ElementAt(countRoom).Devices.Count; i++) {
                item = new ListViewItem(house.Rooms.ElementAt(countRoom).Devices.ElementAt(i).NameOfDevice);
                listView.Items.Add(item);
                item.SubItems.Add((house.Rooms.ElementAt(countRoom).Devices.ElementAt(i).Consumption).ToString());
                if ((house.Rooms.ElementAt(countRoom).Devices.ElementAt(i).Type == ApplianceType.Electrical))
                    item.SubItems.Add("Електричество");
                else if ((house.Rooms.ElementAt(countRoom).Devices.ElementAt(i).Type == ApplianceType.Water))
                    item.SubItems.Add("Вода");
                else
                    item.SubItems.Add("Газ");
            }
        }

        private void butBackForm_Click(object sender, EventArgs e)
        {
            panelRoomsDevices.Visible = false;
        }

        private void butAddDevice_Click(object sender, EventArgs e)
        {
            panelSettingsDevice.Visible = false;
            panelAddNewDevice.Visible = true;
        }

        private void butDelDevice_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0) // проверка на наличие выделенного элемента listview
            {
                //house.Rooms.ElementAt(countRoom).Devices.RemoveAt(listView.SelectedItems[0].Index);
                house.Rooms.ElementAt(countRoom).Devices.RemoveAt(listView.SelectedItems[0].Index);
                //listView.Items.Count();
                listView.Items.Remove(listView.SelectedItems[0]);
                house.countDevice[countRoom]--;
            }
            else
                MessageBox.Show("Выберите прибор который хотите удалить.");
        }

        private void tbPowerDevice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBoxNameDevice.Text) || string.IsNullOrEmpty(tbPowerDevice.Text) || string.IsNullOrEmpty(cbTypeOfUsage.Text))
            {
                MessageBox.Show("Не все поля заполнены.");
                return;
            }
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].Text == textBoxNameDevice.Text)
                {
                    MessageBox.Show("Прибор с таким именем уже существует");
                    return;
                }
            }
            item = new ListViewItem(textBoxNameDevice.Text);
            item.SubItems.Add(tbPowerDevice.Text);
            item.SubItems.Add(cbTypeOfUsage.Text);
            listView.Items.Add(item);
            
            house.Rooms.ElementAt(countRoom).Devices.Add(new DeviceBase());
            house.Rooms.ElementAt(countRoom).Devices.ElementAt(house.countDevice[countRoom]).NameOfDevice = textBoxNameDevice.Text;
            if (cbTypeOfUsage.Text == "Вода")
            {
                house.Rooms.ElementAt(countRoom).Devices.ElementAt(house.countDevice[countRoom]).Type = ApplianceType.Water;

            }
            else if (cbTypeOfUsage.Text == "Електричество")
            {
                house.Rooms.ElementAt(countRoom).Devices.ElementAt(house.countDevice[countRoom]).Type = ApplianceType.Electrical;
            }
            else if (cbTypeOfUsage.Text == "Газ")
            {
                house.Rooms.ElementAt(countRoom).Devices.ElementAt(house.countDevice[countRoom]).Type = ApplianceType.Gas;
            }
            house.Rooms.ElementAt(countRoom).Devices.ElementAt(house.countDevice[countRoom]).Consumption = double.Parse(tbPowerDevice.Text);
            textBoxNameDevice.Clear();
            tbPowerDevice.Clear();
            panelAddNewDevice.Visible = false;
            house.countDevice[countRoom]++;

        }
        
        private void butOnDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems[0] != null) // проверка на наличие выделенного элемента listview
                {
                    panelAddNewDevice.Visible = false;
                    panelSettingsDevice.Visible = true;
                    lbNameDevWhichSetting.Text = listView.SelectedItems[0].Text;
                    indexItemListView = listView.SelectedItems[0].Index; // присвоение индекса элемента который был выделен
                    btOnDevice.Text = house.Rooms.ElementAt(countRoom).Devices.ElementAt(indexItemListView).StatusOfDevice ? "Выключить" : "Включить";
                }
            } catch (Exception)
            {
                MessageBox.Show("Выберите прибор который хотите настроить.");
            }
        }

        private void panelKitchenDevices_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btOnDevice_Click(object sender, EventArgs e)
        {
            panelChangePowerDevice.Visible = false;
            panelChangeName.Visible = false;
            if (!house.Rooms.ElementAt(countRoom).Devices.ElementAt(indexItemListView).StatusOfDevice)
            {
                house.Rooms.ElementAt(countRoom).Devices.ElementAt(indexItemListView).StatusOfDevice = true;
                house.Rooms.ElementAt(countRoom).Devices.ElementAt(indexItemListView).Toggle();
                btOnDevice.Text = "Выключить";
            }
            else
            {
                house.Rooms.ElementAt(countRoom).Devices.ElementAt(indexItemListView).StatusOfDevice = false;
                house.Rooms.ElementAt(countRoom).Devices.ElementAt(indexItemListView).Toggle();
                btOnDevice.Text = "Включить";
            }

        }
        

        private void butRoomsDevices_Click(object sender, EventArgs e)
        {
            Button clickButton = (Button)sender;
            labelNameRoom.Text = clickButton.Text;
            if (labelNameRoom.Text == "Кухня")
                countRoom = 0;
            else if (labelNameRoom.Text == "Ванная")
                countRoom = 1;
            else if (labelNameRoom.Text == "Спальня")
                countRoom = 2;
            else
                countRoom = 3;
            LoadListView();
            panelAddNewDevice.Visible = false;
            panelSettingsDevice.Visible = false;
            panelRoomsDevices.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSettingsDevice.Visible = false;
        }

        private void textBoxNameDevice_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].Text == textBoxNameDevice.Text)
                {
                    MessageBox.Show("Прибор с таким именем уже существует");
                    textBoxNameDevice.BackColor = Color.Red;
                }
            }
        }

        private void textBoxNameDevice_Click(object sender, EventArgs e)
        {
            textBoxNameDevice.BackColor = Color.White;
        }

        private void btChangeName_Click(object sender, EventArgs e)
        {
            panelChangePowerDevice.Visible = false;
            panelChangeName.Visible = true;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            listView.Items[indexItemListView].Text = lbChangeNameDevice.Text;
            house.Rooms.ElementAt(countRoom).Devices.ElementAt(indexItemListView).NameOfDevice = lbChangeNameDevice.Text;
            
            lbNameDevWhichSetting.Text = lbChangeNameDevice.Text;
            MessageBox.Show("Название успешно изменено");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView.Items[indexItemListView].SubItems[1].Text = tbChangePower.Text;
            house.Rooms.ElementAt(countRoom).Devices.ElementAt(indexItemListView).Consumption = double.Parse(tbChangePower.Text);
            MessageBox.Show("Мощность успешно изменена");
        }

        private void btChangePower_Click(object sender, EventArgs e)
        {
            panelChangeName.Visible = false;
            panelChangePowerDevice.Visible = true;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
