using System.Security.Cryptography.X509Certificates;

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
            //stringFunc = new StringFincDelegate(StringFunctions.GetCountOfUpperCase);

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

            //string[] names = { "Omar", "Mohamed", "Amr", "Salma" };

            //SortingAlgorithm<string>.BubbleSort(names, SortingTypes.SortAsc);

            //SortTypesFuncDelegate<string, string, bool> sortingTypes = SortingTypes.SortDesc;

            //SortingAlgorithm<string>.BubbleSort(names, sortingTypes);


            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Example 03

            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            ////List<int> OddNumbers = FilterLists.FindOddNumbers(Numbers);


            //List<int> OddNumbers = FilterLists.FindElemets(Numbers, FilterOfList.CheckOdd);
            //foreach (var item in OddNumbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //List<int> EvenNumbers = FilterLists.FindElemets(Numbers, FilterOfList.CheckEven);

            //foreach (var item in EvenNumbers)
            //{
            //    Console.Write($"{item} ");
            //}

            //List<string> names = new List<string>() { "Ahmed", "Aya", "Khaked", "Rawan", "Amr", "Heba", "Hadeer"};

            //List<string> Names = ["Ahmed", "Aya", "Khaked", "Rawan", "Amr", "Heba", "Heba"];

            //List<string> filterName01 = FilterLists.FindElemets(Names, FilterOfList.CheckLengthLessThanFour);

            //foreach (var item in filterName01)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> filterName02 = FilterLists.FindElemets(Names, FilterOfList.CheckLengthMoreThanFour);

            //foreach (var item in filterName02)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region Built In Delegate

            //Predicate<int> predicate = TestBuiltInDelegate.CheckPositive;

            //bool flag = predicate.Invoke(10);

            //Console.WriteLine(flag);

            //Func<int, string> func = TestBuiltInDelegate.Casting;
            //string number = func.Invoke(42);

            //Console.WriteLine(number);

            //Action action = TestBuiltInDelegate.Print;

            //action.Invoke();

            //Action<string> action = TestBuiltInDelegate.Print;
            //action.Invoke("Mahmoud");



            #endregion

            #region Anonymous Methods
            //Action action01 = delegate () { Console.WriteLine("Hello Route"); };
            //action01();

            //Action<string> action02 = delegate (string name) { Console.WriteLine($"Hello {name}"); };
            //action02("Mahmoud");

            //Func<int, string> func = delegate (int number) { return number.ToString(); };
            //Console.WriteLine(func.Invoke(32));

            //Predicate<int> predicate = delegate (int number) { return number > 0; };
            //Console.WriteLine(predicate.Invoke(32));

            #endregion

            #region Lambda Expression
            //Action action01 = () => { Console.WriteLine("Hello Route"); };
            //action01();

            //Action<string> action02 = (name) =>{ Console.WriteLine($"Hello {name}"); };
            //action02("Mahmoud");

            //Func<int, string> func = (number) => { return number.ToString(); };
            //Console.WriteLine(func.Invoke(32));

            //Predicate<int> predicate = (number) => { return number > 0; };
            //Console.WriteLine(predicate.Invoke(32));
            #endregion

        }
    }
}
