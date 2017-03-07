using System.Collections.Generic;
using System.Threading;

namespace GOP_01
{
    internal class User
    {
        private static int _id;

        public int Id { get; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public User Manager { get; set; }
        public List<AssetItem> AssetsItems { get; set; }

        public User()
        {
            Id = Interlocked.Increment(ref _id);
        }

        public User(string username, string name, string department, User manager, List<AssetItem> assetsItems)
        {
            Id = Interlocked.Increment(ref _id);
            Username = username;
            Name = name;
            Department = department;
            Manager = manager;
            AssetsItems = assetsItems ?? new List<AssetItem>();
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() * 397;
        }
    }
}