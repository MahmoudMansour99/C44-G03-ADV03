using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool SortTypesFuncDelegate(int a, int b);
    internal static class SortingAlgorithm
    {
        public static void BubbleSort(int[] Arr, SortTypesFuncDelegate sortingTypes)
        {
            if (Arr?.Length > 0 && sortingTypes is not null)
                for (int i = 0; i < Arr.Length; i++)
                    for (int j = 0; j < Arr.Length - 1 - i; j++)
                        if (sortingTypes(Arr[j], Arr[j + 1]))
                            Swap(ref Arr[j], ref  Arr[j + 1]);
        }

        public static void BubbleSortDesc(int[] Arr)
        {
            if (Arr?.Length > 0)
                for (int i = 0; i < Arr.Length; i++)
                    for (int j = 0; j < Arr.Length - 1 - i; j++)
                        if (Arr[j] < Arr[j + 1])
                            Swap(ref Arr[j], ref Arr[j + 1]);
        }

        public static void Swap(ref int X, ref int Y)
        {
            int Temp = X; 
            X = Y; 
            Y = Temp;
        }
    }
}
