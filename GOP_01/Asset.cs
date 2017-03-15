using System;

namespace GOP_01
{
    internal abstract class Asset : IEquatable<Asset>
    {
        protected Guid Id { get; }
        protected string Manufacturer { get; set; }
        protected string Model { get; set; }
        protected string Description { get; set; }
        protected decimal PurchasePrice { get; set; }
        protected DateTime PurchaseDate { get; set; }

        protected Asset()
        {
            Id = Guid.NewGuid();
        }

        protected Asset(string manufacturer, string model, string description, decimal price, DateTime purchaseDate)
        {
            Id = Guid.NewGuid();
            Manufacturer = manufacturer;
            Model = model;
            Description = description;
            PurchasePrice = price;
            PurchaseDate = purchaseDate;
        }

        public override string ToString() => $"AssetItem: Id:{Id}, Model:{Model}, Description:{Description}";

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            var other = obj as Asset;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id.GetHashCode();
                hashCode = (hashCode * 397) ^ (Manufacturer?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Model?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Description?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ PurchasePrice.GetHashCode();
                hashCode = (hashCode * 397) ^ PurchaseDate.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Asset a, Asset b)
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

        public static bool operator !=(Asset a, Asset b)
        {
            return !(a == b);
        }

        public bool Equals(Asset other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id.Equals(other.Id) && string.Equals(Manufacturer, other.Manufacturer) &&
                   string.Equals(Model, other.Model) && string.Equals(Description, other.Description) &&
                   PurchasePrice == other.PurchasePrice && PurchaseDate.Equals(other.PurchaseDate);
        }
    }
}
