using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD g;
            g = new CD(205, "CD");
            g.Spin();
            g.MakeSound();
            g.Encode();

            DVD f;
            f = new DVD(600, "DVD");
            f.Spin();
            f.MakeSound();
            f.Encode();
            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
