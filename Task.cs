using System.Collections.Generic;

namespace TaskTimer
{
    public class Task
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }
        public List<Session> Sessions { get; set; }
    }
}