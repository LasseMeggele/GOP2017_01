using System;

namespace GOP_01
{
    internal class ServiceContract : IEquatable<ServiceContract>
    {
        private static int _id;

        public int Id { get; }
        public string Name { get; set; }
        public string Type { get; set; }
        public TimeSpan Duration { get; set; }
        
        public ServiceContract()
        {
            Id = System.Threading.Interlocked.Increment(ref _id);
        }

        public ServiceContract(string name, string type, TimeSpan duration)
        {
            Id = System.Threading.Interlocked.Increment(ref _id);
            Name = name;
            Type = type;
            Duration = duration;
        }

        public bool Equals(ServiceContract other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && string.Equals(Name, other.Name) && string.Equals(Type, other.Type) &&
                   Duration.Equals(other.Duration);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ServiceContract) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id;
                hashCode = (hashCode * 397) ^ (Name?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Type?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}