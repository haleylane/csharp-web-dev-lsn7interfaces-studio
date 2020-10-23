using System;
namespace SpinningDiscs
{
    public abstract class Disc
    {
        public int MaxStorage { get; set; }
        public string Type { get; set; }


        public abstract void Spin();

        public Disc(int maxStorage, string type)
        {
            MaxStorage = maxStorage;
            Type = type;

        }
    }
}
