using System;

namespace Abstraction_interface
{
    class Program_interface
    {
        static void Main(string[] args)
        {
            Iikan ikan;

            ikan = new tawar();
            ikan.air();

            Console.WriteLine();
            ikan = new laut();
            ikan.air();
        }
    }
}
