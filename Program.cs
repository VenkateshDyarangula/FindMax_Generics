using System;

namespace UC1_Generics_To_FindMaxValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MaxInteger!");
           int gc = GenericClass<int>.maximum(2, 14, 6);
           Console.WriteLine(gc);
        }
    }

}
