using System;

namespace UC3_MaxString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MaxInteger!");
            int gci = GenericClass<int>.maximum(2, 14, 16);
            Console.WriteLine(gci);
            Console.WriteLine("MaxFloat!");
            float gcf = GenericClass<int>.maximum(2.25f, 14.43f, 6.15f);
            Console.WriteLine(gcf);
            Console.WriteLine("MaxString!");
            string gcs = GenericClass<int>.maximum("Peach", "Apple", "Banana");
            Console.WriteLine(gcs);

        }
    }
}
