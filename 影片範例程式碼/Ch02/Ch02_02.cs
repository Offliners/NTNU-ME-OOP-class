/***************************************
 * Variables
 * Author: S.D.Wu
 * Date: 2014/2/16
 **************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    class Ch02_02
    {
        static void Main(string[] args)
        {
            short x;  //Declare variable x with short type 
            x = 2; //Assign value 2 to variable x
            int y = 5; //Declare variable y and assign 5 to y
            float z= 1.5f;
            double w= 5.54;
            bool b = true;
            Console.WriteLine("x={0},y={1},z={2},w={3}",x,y,z,w);
            Console.WriteLine("b={0}", b);
            //calculate the storage sizes of the data types 
            Console.WriteLine("size of data type ");
            Console.WriteLine("size of short ={0}", sizeof(short));
            Console.WriteLine("size of int ={0}", sizeof(int));
            Console.WriteLine("size of float ={0}", sizeof(float));
            Console.WriteLine("size of double ={0}", sizeof(double));
            Console.WriteLine("size of bool ={0}", sizeof(bool));
            Console.Read();
        }
    }
}
