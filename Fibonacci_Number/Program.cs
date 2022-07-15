
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Fibonacci_Number
{
   class program
    {
        public static void Main()
        {
            Fibonacci fibonacciObj = new Fibonacci(); ;
            fibonacciObj.FindFibonacciNumber();

            Console.ReadKey();

            fibonacciObj.CheckFibonacciNumber();
        }        
        
    }
}
