using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool FilterFuncDelegate<T>(T a);
    internal static class FilterLists
    {
        public static List<T> FindElemets<T>(List<T> numbers, FilterFuncDelegate<T> filter)
        {
            List<T> Result = new List<T>();
            if (numbers?.Count > 0 && filter is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    //if (numbers[i] % 2 == 1)
                    if (filter(numbers[i]))
                    {
                        Result.Add(numbers[i]); 
                    }
                }
            }
            return Result;
        }

        public static List<int> FindEvenNumbers(List<int> numbers)
        {
            List<int> Result = new List<int>();
            if (numbers?.Count > 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Result.Add(numbers[i]);
                    }
                }
            }
            return Result;
        }
    }
}
