using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PassingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeFunc(PassFunc);
            Console.ReadLine();
        }
        static int PassFunc(int x)
        {
            return x * x;
        }
        static void SomeFunc(Func<int, int> PassFunc)
        {
            int i = PassFunc(10);
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("Function to be executed is: {0}", GetCurrentMethodName());
        }
        public static string GetCurrentMethodName()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(1);

            return stackFrame.GetMethod().Name;
        }
    }
}
