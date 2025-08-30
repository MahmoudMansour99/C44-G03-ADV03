namespace Demo
{
    public delegate int StringFincDelegate(string s); 
    // New Delegate [Class]
    // Ref from Delegate can refer to a function or more [Pointer to Function]
    // This Function can be static function [Class Memebr Function]
    // This Function can be Non-static function [Object Memebr Function]
    // this function must be with same signature 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate

            #region Example 01
            //int x = StringFunctions.GetCountOfUpperCase(); // Invalid
            // 1. Declare Referance from Delegate
            //StringFincDelegate stringFunc;

            //// 2. Initialize Referance from Delegate [Pointer to Function]
            ////stringFunc = new StringFincDelegate(StringFunctions.GetCountOfUpperCase);

            //stringFunc = StringFunctions.GetCountOfUpperCase;

            //stringFunc += StringFunctions.GetCountOfLowerCase;
            //stringFunc -= StringFunctions.GetCountOfLowerCase;


            //// 3. use Delegate Referance [Call Method]

            //int Result = stringFunc?.Invoke("RouTe") ?? 0;
            ////Result = stringFunc.Invoke("MahmoUd ManSOuR");

            //Console.WriteLine(Result);
            #endregion

            #region Example 02

            //int[] numbers = { 7, 5, 6, 3, 2, 1, 8, 9, 4 };

            ////SortingAlgorithm.BubbleSort(numbers);
            ////SortingAlgorithm.BubbleSort(numbers, SortingTypes.CompareGreater);

            //SortTypesFuncDelegate<int> sortingTypes = SortingTypes.CompareLess;

            //SortingAlgorithm<int>.BubbleSort(numbers, sortingTypes);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            string[] names = { "Omar", "Mohamed", "Amr", "Salma" };

            SortingAlgorithm<string>.BubbleSort(names, SortingTypes.SortAsc);

            SortTypesFuncDelegate<string, string, bool> sortingTypes = SortingTypes.SortDesc;

            SortingAlgorithm<string>.BubbleSort(names, sortingTypes);


            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            #endregion

            #endregion

        }
    }
}
