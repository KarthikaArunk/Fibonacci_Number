using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Number
{
    public class Fibonacci
    {       
        //Get the nth number in the fibonacci sequence given 'n'
        public void FindFibonacciNumber()
        {
            int firstnumber = 0, secondnumber = 1, nextnumber, n;
            
            Console.WriteLine("\n");
            Console.WriteLine("Fibonacci Number");
            Console.WriteLine("\n");
            Console.Write("Enter an index number:  ");
            n = int.Parse(Console.ReadLine());
            n = n - 1;

            for (int i = 2; i <= n; i++)
            {
                nextnumber = firstnumber + secondnumber;                               
                firstnumber = secondnumber;
                secondnumber = nextnumber;
            }
            Console.WriteLine(secondnumber);
            Console.WriteLine("\n");
        }

        //Check whether a number is fibonacci or not
       public void CheckFibonacciNumber()
        {
            int n;
            
            Console.WriteLine("Enter a number:  ");
            n = int.Parse(Console.ReadLine());

            
            var fibonacci = GetFibonacciByNumber(n);
            if (fibonacci.Contains(n))
            {
                Console.WriteLine($"{n} is a fibonacci Number ");
            }
            else
            {
                Console.WriteLine($"{n} is not a fibonacci number, Closest Index is: {fibonacci.Length - 1}");
            }
            
        }

        
        public int[] GetFibonacciByNumber(int number)
        {
            int value1 = 0, value2 = 1, value3;
            value3 = value1 + value2;
            var fibonacci = new List<int>();
            if(number == 0) {
                fibonacci.Add(0);
                return fibonacci.ToArray();
            }
            if (number == 1)
            {
                fibonacci.Add(0);
                fibonacci.Add(1);
                return fibonacci.ToArray();
            }
            
            fibonacci.Add(0);
            fibonacci.Add(1);
            fibonacci.Add(1);
            while(value3 <= number)
            {
                fibonacci.Add(value3);
                value1 = value2;
                value2 = value3;
                value3 = value1 + value2;
            }
            return fibonacci.ToArray();
        }
     }
}
