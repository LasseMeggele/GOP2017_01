using System;

namespace GOP_01
{
    internal abstract class AssetItem
    {
        public Guid Id { get; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }

        protected AssetItem()
        {
            Id = Guid.NewGuid();
        }

        protected AssetItem(string manufacturer, string model, string description)
        {
            Id = Guid.NewGuid();
            Manufacturer = manufacturer;
            Model = model;
            Description = description;
        }

        public override string ToString()
        {
            return $"AssetItem: Id:{Id}, Model:{Model}, Description:{Description}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            var assetItem = (AssetItem) obj;

            return Id.Equals(assetItem.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() * 397;
        }

        public static bool operator ==(AssetItem a, AssetItem b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object) a == null) || ((object) b == null))
            {
                return false;
            }

            return a.Id == b.Id;
        }

        public static bool operator !=(AssetItem a, AssetItem b)
        {
            return !(a == b);
        }
    }
}
