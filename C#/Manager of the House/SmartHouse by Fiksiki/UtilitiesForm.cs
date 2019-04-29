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
    public partial class UtilitiesForm : UserControl
    {
        public House house;

        public UtilitiesForm(House house)
        {
            this.house = house;
            InitializeComponent();
            
        }
        public double CountPrice(ApplianceType kek)
        {
            double priceCount = 0;
            for (int i = 0; i < house.Rooms.Count; i++)
            {
                for (int j = 0; j < house.Rooms[i].Devices.Count; j++)
                {
                    if (house.Rooms[i].Devices[j].Type == kek)
                    {
                        priceCount += house.Rooms[i].Devices[j].GetConsumption();
                    }
                }
            }
            return priceCount; //можно округлить
        }

        public double[] TranslateToGrivna(double priceCount)
        {
            double[] priceGrivna = new double[] { 0, 0 };
            if (priceCount > 100)
            {
                priceGrivna[0] = (int)(priceCount / 100);
                priceGrivna[1] = priceCount % 100;
            }
            else
            {
                priceGrivna[0] = priceGrivna[0];
                priceGrivna[1] = Math.Round(priceCount, 2);
            }
            return priceGrivna;
        }

        private void UtilitiesForm_Load(object sender, EventArgs e)
        {
            double[] price1 = TranslateToGrivna(CountPrice(ApplianceType.Electrical)),
                     price2 = TranslateToGrivna(CountPrice(ApplianceType.Water)),
                     price3= TranslateToGrivna(CountPrice(ApplianceType.Gas)),
                     priceGeneral = { price1[0] + price2[0] + price3[0], price1[1] + price2[1] + price3[1] };
            lbGetElectUtilities.Text = price1[0] + " гривен " + price1[1] + " копеек ";
            lbGetWaterUtilities.Text = price2[0] + " гривен " + price2[1] + " копеек ";
            lbGetGasUtilities.Text = price3[0] + " гривен " + price3[1] + " копеек ";
            lbGeneralUtilities.Text = priceGeneral[0] + " гривен " + priceGeneral[1] + " копеек ";

        }
    }
}
