using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            int turn = 0;
            int sum = 0;
            int residence;
            Console.WriteLine("s = (100000*a + 10000*b + 1000*c + 100*d + 10*e + f) , 0 <= a,b,c,d,e,f <= 9");
            Console.Write("請輸入一個整數: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("請輸入要印出幾個符合條件的數字: ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("符合 s = (10*a+b)^3 + (10*c+d)^3 + (10*e+f)^3條件的數字有:");
            for(int count = 1;count<=n;count++)
            {
                int temp;
                int num = 0;
                temp = count;
                while (temp != 0)
                {
                    residence = temp % 100;
                    temp = temp / 100;
                    num += residence * residence * residence;
                }
                if (count == num)
                {
                    Console.WriteLine(count);
                    turn++;
                    sum += count;
                }
                if (turn >= k)
                    break;
            }
            Console.WriteLine("數字總合為: {0}",sum);
            Console.ReadKey();
        }
    }
}
