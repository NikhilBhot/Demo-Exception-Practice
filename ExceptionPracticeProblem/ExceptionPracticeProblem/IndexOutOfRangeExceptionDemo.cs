using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPracticeProblem
{
    internal class IndexOutOfRangeExceptionDemo
    {
        public static void indexOutOfRangeExceptionMethod() 
        {
            //Console.WriteLine("Enter The Array Size");
            //int size=Convert.ToInt32(Console.ReadLine());
            //int[]arr= new int[size];
            int[]arr= new int[3];

            try
            {
                //for(int i = 0; i < size; i++)
                //{
                //    arr[i]=Convert.ToInt32(Console.ReadLine());
                //}
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                arr[3] = 4; //Array Size Is 3 

                foreach (int i in arr)
                {
                    Console.WriteLine(i);

                }
            }
            
            catch(IndexOutOfRangeException Ie) 
            {
                Console.WriteLine("Please Check Array Size");
                Console.WriteLine(Ie.Message);
            }
            

        }
    }
}
