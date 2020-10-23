using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : Disc, IDisc
    {
        public string AlbumName { get; set; }
        public List<string> SongNames { get; set; }
        public CD(int maxStorage, string type) : base(maxStorage, type) { }
        public override void Spin()
        {
            Console.WriteLine("CD is spinning");
        }
        public void Encode()
        {
            Console.WriteLine("I've been encoded with CD info");

        }


        public void MakeSound()
        {
            Console.WriteLine("CD audio is playing");
        }


        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
