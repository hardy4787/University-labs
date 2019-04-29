using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace BL.Objects.Objects.Devices
{
    [DataContract]
    public class DeviceBase: IDevice
    {
        [DataMember]
        public ApplianceType Type { get; set; } // Перечисление видов енергии
        [DataMember]
        public bool StatusOfDevice { get; set; }
        [DataMember]
        public string NameOfDevice { get; set; }
        [DataMember]
        public double Consumption { get; set; } // Потребление/мощность
        [DataMember]
        private List<Period> ActivityPeriods { get; set; } = new List<Period>(); //Список переиодов между вкл/выкл, которое сумируется
        [DataMember]
        private Period Period { get; set; } = new Period();

        public void Toggle()
        {
            if (Period.StartDate == null)
            {
                Period.StartDate = DateTime.Now;
                return;
            }

            Period.EndDate = DateTime.Now;
            
            ActivityPeriods.Add(Period);

            Period = new Period();
        }

        public double GetConsumption()
        {
           
            if (this.Type == ApplianceType.Water)
                return GetActivityTime() * Consumption; //дописать
            else if (this.Type == ApplianceType.Electrical)
                return GetActivityTime() * Consumption;
            else // Газ
                return GetActivityTime() * Consumption;
        }

        public int GetActivityTime()
        {
            return ActivityPeriods.Sum(x => x.EndDate.Value.Subtract(x.StartDate.Value).Seconds);
        }

        public DeviceBase(string name, ApplianceType usegeEnergy, double power = 0)
        {
            NameOfDevice = name;
            Consumption = power;
            Type = usegeEnergy;
            StatusOfDevice = false;
        }


        public DeviceBase()
        {
            NameOfDevice = null;
            Consumption = 0;
            Type = ApplianceType.Electrical;
            StatusOfDevice = false;
        }
    }
}
