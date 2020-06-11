using System;

namespace Abstrction
{
    class Program
    {
        static void Main(string[] args)
        {
            ikan ikan;

            ikan = new tawar();
            ikan.air();

            Console.WriteLine();
            ikan = new laut();
            ikan.air();

            Console.ReadKey();
        }
    }
}
