using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate Tout SortTypesFuncDelegate<in T1, in T2, out Tout>(T1 a, T2 b);
    internal static class SortingAlgorithm<T>
    {
        public static void BubbleSort(T[] Arr, SortTypesFuncDelegate<T, T, bool> sortingTypes)
        {
            if (Arr?.Length > 0 && sortingTypes is not null)
                for (int i = 0; i < Arr.Length; i++)
                    for (int j = 0; j < Arr.Length - 1 - i; j++)
                        if (sortingTypes(Arr[j], Arr[j + 1]))
                            Swap(ref Arr[j], ref  Arr[j + 1]);
        }
        public static void Swap(ref T X, ref T Y)
        {
            T Temp = X; 
            X = Y; 
            Y = Temp;
        }
    }
}
