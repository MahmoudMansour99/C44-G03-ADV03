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
            //int x = StringFunctions.GetCountOfUpperCase(); // Invalid
            // 1. Declare Referance from Delegate
            StringFincDelegate stringFunc;

            // 2. Initialize Referance from Delegate [Pointer to Function]
            //stringFunc = new StringFincDelegate(StringFunctions.GetCountOfUpperCase);

            stringFunc = StringFunctions.GetCountOfUpperCase;

            stringFunc += StringFunctions.GetCountOfLowerCase;
            stringFunc -= StringFunctions.GetCountOfLowerCase;


            // 3. use Delegate Referance [Call Method]

            int Result = stringFunc?.Invoke("RouTe") ?? 0;
            //Result = stringFunc.Invoke("MahmoUd ManSOuR");

            Console.WriteLine(Result);
        }
    }
}
