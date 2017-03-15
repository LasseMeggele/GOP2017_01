using System;
using System.Collections.Generic;
using System.Threading;

namespace GOP_01
{
    internal class User : IEquatable<User>
    {
        private static int _id;

        public int Id { get; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public User Manager { get; set; }
        public List<Asset> AssetsItems { get; set; }

        public User()
        {
            Id = Interlocked.Increment(ref _id);
        }

        public User(string username, string name, string department, User manager, List<Asset> assetsItems)
        {
            Id = Interlocked.Increment(ref _id);
            Username = username;
            Name = name;
            Department = department;
            Manager = manager;
            AssetsItems = assetsItems ?? new List<Asset>();
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id;
                hashCode = (hashCode * 397) ^ (Username?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Name?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Department?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Manager?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (AssetsItems?.GetHashCode() ?? 0);
                return hashCode;
            }
        }

        public bool Equals(User other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && string.Equals(Username, other.Username) && string.Equals(Name, other.Name) &&
                   string.Equals(Department, other.Department) && Equals(Manager, other.Manager) &&
                   Equals(AssetsItems, other.AssetsItems);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((User) obj);
        }

        public override string ToString() => $"Id: {Id}, Username: {Username}, Name: {Name}, Department: {Department}, Manager: {Manager?.Name}";
    }
}