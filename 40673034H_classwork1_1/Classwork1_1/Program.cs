using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1;
            double sum2;
            for(int i = 1; i <= 9;i++)
            {
                for(int j = 0; j <= 9;j++)
                {
                    for (int k = 0; k <= 9; k++)
                    { 
                        sum1 = 100 * i + 10 * j + k;
                        sum2 = Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(k, 3);
                        if (sum1 == sum2)
                            Console.WriteLine(sum1);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
