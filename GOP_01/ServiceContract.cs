using System;

namespace GOP_01
{
    internal class ServiceContract
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
    }
}