using System;

namespace GOP_01
{
    internal class Accesory : AssetItem
    {
        public string Serialnumber { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public TimeSpan SupportDuration { get; set; }

        public Accesory() {}

        public Accesory(string manufacturer, string name, string description, string serialnumber) : base(manufacturer, name, description)
        {
            Serialnumber = serialnumber;
        }


    }
}
