/**************************************************
 * Pass array to function
 * Author: S.D. Wu
 * Date: 2014/3/3
 * ************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04
{
    class Ch04_01
    {
        static void Main(string[] args)
        {
            // Declare a single-dimensional array and 
            double[] dArray = { 1.0, 3.0, 5.0, 7.0, 9.2, 8.4, 6.3};

            //find the maxmum
            Console.WriteLine("Elements of Array are:");
            arrayPrint(dArray);
            Console.WriteLine();
            Console.WriteLine("The maximum of array is {0:F2}", arrayMax(dArray));
            
            //add 1 to each element of array
            arrayModified(dArray);
            Console.WriteLine("Elements of Array are:");
            arrayPrint(dArray);
           
            Console.Read();
        }
        /// <summary>
        /// find the maximun of array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static double arrayMax(double[] arr)
        {
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        /// <summary>
        /// Print the array 
        /// </summary>
        /// <param name="arr"></param>
        static void arrayPrint(double[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write("{0:F2} ", element);
            }
        }
        /// <summary>
        /// Add 1 to each element of array
        /// </summary>
        /// <param name="arr"></param>
        static void arrayModified(double[] arr)
        {
            for (int i = 0 ; i < arr.Length ; i++)
            {
                arr[i]++;
            }
        }
    }
}
