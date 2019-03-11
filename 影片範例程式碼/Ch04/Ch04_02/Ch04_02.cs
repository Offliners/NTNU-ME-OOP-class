using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch03.MyPoint;

namespace CH04
{
    class Ch04_02
    {
        static void Main(string[] args)
        {
            
            //array of struct variable
            MyPoint_S[] struArr = new MyPoint_S[3];
            //Assign values to element of array
            for (int i = 0; i < struArr.Length; i++)
            {
                struArr[i].X = i+1;
                struArr[i].Y = (struArr[i].X) * (struArr[i].X);
            }
           

            //array of instance of class
            MyPoint_C[] classArr = new MyPoint_C[3];
            //new operator is necessay 
            for (int i = 0; i < classArr.Length; i++)
                classArr[i] = new MyPoint_C();
            //Assign values to element of array
            for (int i = 0; i < classArr.Length; i++)
            {
                classArr[i].X = i + 1;
                classArr[i].Y = (classArr[i].X) * (classArr[i].X) * (classArr[i].X);
            }
            
           
            //使用 for 列印陣列內容
            Console.WriteLine("=========使用 fore======");
            Console.WriteLine("=========結構變數陣列測試======");
            for (int i = 0; i < struArr.Length; i++)
                Console.WriteLine("({0},{1})", struArr[i].X, struArr[i].Y);
            Console.WriteLine("=========類別變數陣列測試======");
            for (int i = 0; i < struArr.Length; i++)
                Console.WriteLine("({0},{1})", classArr[i].X, classArr[i].Y);

            //使用 foreach +var 列印陣列內容
            Console.WriteLine("=========使用 foreach +var======");
            Console.WriteLine("=========結構變數陣列測試======");
            foreach (var element in struArr)
                Console.WriteLine("({0},{1})", element.X, element.Y);

            Console.WriteLine("=========類別變數陣列測試======");
            foreach (var element in classArr)
                Console.WriteLine("({0},{1})", element.X, element.Y);

            Console.Read();
        }
    }
}
