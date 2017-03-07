using System;
using System.Collections.Generic;

namespace GOP_01
{
    internal class Computer : AssetItem
    {
        public string Serialnumber { get; set; }
        public string AssetTag { get; set; }
        public string Uuid { get; set; }
        public List<string> MacAddress { get; set; }
        public ServiceContract ServiceContract { get; set; }

        internal Computer() {}

        internal Computer(string model, string serialnumber)
        {
            Model = model;
            Serialnumber = serialnumber;
            MacAddress = new List<string>();
        }

        internal Computer(string manufacturer, string model, string description, decimal price, DateTime purchaseDate,
            string serialnumber, string uuid, List<string> macAddressList, ServiceContract serviceContract)
            : base(manufacturer, model, description, price, purchaseDate)
        {
            Serialnumber = serialnumber;
            Uuid = uuid;
            MacAddress = macAddressList ?? new List<string>();
            ServiceContract = serviceContract;
        }

        public override string ToString()
        {
            return
                $"{base.ToString()}; Serialnumber: {Serialnumber}; AssetTag: {AssetTag}; Uuid: {Uuid}, MacAddress: {(MacAddress != null ? string.Join(", ", MacAddress.ToArray()) : null)}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            var computer = (Computer) obj;

            return Id.Equals(computer.Id);
        }
    }
}
