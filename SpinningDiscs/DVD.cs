using System;
namespace SpinningDiscs
{
    public class DVD : Disc, IDisc
    {
        // TODO: Implement your custom interface.
        string MovieTitle { get; set; }
        string Director { get; set; }

        public DVD(int maxStorage, string type) : base(maxStorage, type)
        {
        }

        public void Encode()
        {
            Console.WriteLine("I've been encoded with DVD info");

        }

        public override void Spin()
        {
            Console.WriteLine("DVD is spinning");
        }

        public void MakeSound()
        {
            Console.WriteLine("DVD audio playing");
        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
