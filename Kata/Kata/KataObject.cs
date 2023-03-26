using System;

namespace Kata
{
    public class KataObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Func<IKata> Created { get; set; }
    }
}