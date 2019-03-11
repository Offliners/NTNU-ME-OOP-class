using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1_1_better
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, resident,k;
            int sum;
            for(n = 100; n<=999; n++)
            {
                k = n;
                sum = 0;
                while(k != 0)
                {
                    resident = k % 10;
                    sum += resident * resident * resident;
                    k = k / 10;
                }
                if (n == sum)
                    Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
