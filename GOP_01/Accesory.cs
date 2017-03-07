using System;

namespace GOP_01
{
    internal class Accesory : AssetItem
    {
        public string Serialnumber { get; set; }
        public ServiceContract ServiceContract { get; set; }

        public Accesory() {}

        public Accesory(string manufacturer, string name, string description, decimal price, DateTime purchaseDate,
            string serialnumber) : base(manufacturer, name, description, price, purchaseDate)
        {
            Serialnumber = serialnumber;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Serialnumber: {Serialnumber}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            var accesory = (Accesory)obj;

            return Id.Equals(accesory.Id);
        }
    }
}
