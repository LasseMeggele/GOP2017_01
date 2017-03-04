using System;
using System.Collections.Generic;

namespace GOP_01
{
    internal class Computer : AssetItem
    {
        public string Serialnumber { get; set; }
        public string AssetTag { get; set; }
        public string Uuid { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public TimeSpan SupportDuration { get; set; }
        public List<string> MacAddress { get; set; }

        internal Computer() {}

        internal Computer(string model, string serialnumber)
        {
            Model = model;
            Serialnumber = serialnumber;
            MacAddress = new List<string>();
        }

        internal Computer(string manufacturer, string model, string description, string serialnumber, string uuid, List<string> macAddressList ) : base(manufacturer, model, description)
        {
            Manufacturer = manufacturer;
            Model = model;
            Description = description;
            Serialnumber = serialnumber;
            Uuid = uuid;
            MacAddress = macAddressList ?? new List<string>();
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Serialnumber: {Serialnumber}; AssetTag: {AssetTag}; Uuid: {Uuid}, MacAddress: {(MacAddress != null ? string.Join(", ", MacAddress.ToArray()) : null)}";
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
