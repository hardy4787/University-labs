using System;
using System.Collections.Generic;

namespace BL.Objects.Objects.Devices
{
    
    public interface IDevice
    {
        ApplianceType Type { get; set; }
        bool StatusOfDevice { get; set; } // Состояние устройства.
        string NameOfDevice { get; set; } //Ну тут нужны знания Инглиша.
        double Consumption { get; set; }
        //void _On(List<TypeOfUsage> usg); //Запуск устройства.
    }

    public class Period
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public enum ApplianceType
    {
        Electrical,
        Water,
        Gas
    }
}
