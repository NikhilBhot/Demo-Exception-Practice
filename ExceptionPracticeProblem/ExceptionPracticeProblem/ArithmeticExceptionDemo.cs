using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPracticeProblem
{
    internal class ArithmeticExceptionDemo
    {
        public static void arithmeticException()
        {
            Console.WriteLine("Enter The First Number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            int num2=Convert.ToInt32(Console.ReadLine());
            try
            {
                int result = num1 / num2; //if num2 is 0 then its throws the exception
                Console.WriteLine(result);
            }
            catch(ArithmeticException a)
            {
                Console.WriteLine("Number Never Divide By Zero");
                Console.WriteLine(a.Message);
            }
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
        }
    }
}
