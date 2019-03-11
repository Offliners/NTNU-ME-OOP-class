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
            int[] array0;
            // Declare a single-dimensional array and 
            int[] array1 = new int[5];

            // Declare and set array element values
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax
            int[] array3 = { 1, 3, 5, 7, 9};

            //Use array Elememt
            //use "Length" to get the size of arry
            Console.WriteLine("=========整數陣列測試======");
            //使用 for
            Console.WriteLine("使用for");
            for (int i = 0; i < array3.Length; i++)
                Console.WriteLine("{0}", array3[i]);

            //使用 foreach
            Console.WriteLine("使用foreach");
            foreach (int element in array3)
                Console.WriteLine("{0}", element);

            //使用 foreach + var
            Console.WriteLine("使用foreach + var");
            foreach(var element in array3)
                Console.WriteLine("{0}",element);

           
            Console.Read();
        }
    }
}
