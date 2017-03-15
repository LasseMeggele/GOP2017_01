using System;

namespace GOP_01
{
    internal class Accesory : Asset
    {
        public string Serialnumber { get; set; }
        public ServiceContract ServiceContract { get; set; }

        public Accesory() {}

        public Accesory(string manufacturer, string model, string description, decimal price, DateTime purchaseDate)
            : base(manufacturer, model, description, price, purchaseDate)
        {
        }

        public Accesory(string manufacturer, string model, string description, decimal price, DateTime purchaseDate,
            string serialnumber, ServiceContract serviceContract)
            : base(manufacturer, model, description, price, purchaseDate)
        {
            Serialnumber = serialnumber;
            ServiceContract = serviceContract;
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
