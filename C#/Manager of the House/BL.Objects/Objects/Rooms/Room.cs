using System.Collections.Generic;
using BL.Objects.Objects.Devices;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace BL.Objects.Objects.Rooms
{
    [DataContract]
    public class Room
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<DeviceBase> Devices { get; set; }
        public Room(string name = null, List<DeviceBase> devices = null)
        {
            Name = name;
            Devices = devices;
        }
    }
}
