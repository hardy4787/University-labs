using System.Collections.Generic;
using System.Linq;
using BL.Objects.Objects.Rooms;
using System;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace BL.Objects.Objects.Houses
{
    [DataContract]
    public class House
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<Room> Rooms { get; set; }
        [DataMember]
        private double[] AllConsuption { get; set; }
        [DataMember]
        public int[] countDevice { get; set; }
        public House(string name = null, List<Room> rooms = null)
        {
            AllConsuption = new double[] { 0, 0, 0 };
            countDevice = new int[] { 0, 0, 0, 0 };
            this.Name = name;
            Rooms = rooms;
        }
        

        public double GetAllConsuption(Devices.ApplianceType a)
        {
            //return Rooms?.Sum(x => x.Devices.Where(y => y.Type == a).Sum(y => y.GetConsumption())) ?? 0;
            if (a == Devices.ApplianceType.Electrical) {
                if (AllConsuption[0] <= Rooms.Sum(x => x.Devices.Where(y => y.Type == a).Sum(y => y.GetConsumption()))) {
                    AllConsuption[0] = Rooms?.Sum(x => x.Devices.Where(y => y.Type == a).Sum(y => y.GetConsumption())) ?? 0;
                }
                else
                {
                    AllConsuption[0] += Rooms?.Sum(x => x.Devices.Where(y => y.Type == a).Sum(y => y.GetConsumption())) ?? 0;
                }
                return AllConsuption[0];
            }
            if (a == Devices.ApplianceType.Water)
            {
                if (AllConsuption[1] <= Rooms.Sum(x => x.Devices.Where(y => y.Type == a).Sum(y => y.GetConsumption())))
                {
                    AllConsuption[1] = Rooms?.Sum(x => x.Devices.Where(y => y.Type == a).Sum(y => y.GetConsumption())) ?? 0;
                }
                else
                {
                    AllConsuption[1] += Rooms?.Sum(x => x.Devices.Where(y => y.Type == a).Sum(y => y.GetConsumption())) ?? 0;
                }
                return AllConsuption[1];
            }
            if (a == Devices.ApplianceType.Gas)
            {
                if (AllConsuption[2] <= Rooms.Sum(x => x.Devices.Where(y => y.Type == a).Sum(y => y.GetConsumption())))
                {
                    AllConsuption[2] = Rooms?.Sum(x => x.Devices.Where(y => y.Type == a).Sum(y => y.GetConsumption())) ?? 0;
                }
                else
                {
                    AllConsuption[2] += Rooms?.Sum(x => x.Devices.Where(y => y.Type == a).Sum(y => y.GetConsumption())) ?? 0;
                }
                return AllConsuption[2];
            }


            return -1;
        }

    }
}
