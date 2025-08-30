using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class FunctionReturnDelegate
    {
        public static Action DelegateAction()
        {
            return delegate () { Console.WriteLine("Hello Route"); }; 
        }

    }
}
