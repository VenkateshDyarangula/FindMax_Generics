using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_Generics_To_FindMaxValues
{
    public  class GenericClass<T> where T : IComparable
    {
        public static int maximum(int x, int y, int z)
        {
            int max = x;
            if (y.CompareTo(max) > 0)
                max = y;
            if (z.CompareTo(max) > 0)
                max = z;
            return max;
        }
    }
}
