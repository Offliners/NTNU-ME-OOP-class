using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH08_1_1
{
    class Complex
    {
        private double real;
        private double imag;
        //建構子
        public Complex(double real, double imag)
        {
            this.real = real;
            this.imag = imag;
        }
        //Property
        public double Real
        {
            get { return real; }
            set { real = value; }
        }
        public double Imag
        {
            get { return imag; }
            set { imag = value; }
        }
        
        public static Complex operator *(Complex num1,Complex num2)
        {
            Complex result = new Complex(0, 0);
            result.Real = num1.Real*num2.Real-num1.Imag*num2.Imag;
            result.Imag = num1.Real*num2.Imag+num1.Imag*num2.Real;
            return result;
        } //複數相乘
        public static Complex Power(Complex num,int exp)
        {
            Complex result = new Complex(1, 0);
            if (exp == 0)
                return result;

            for (int i = 0; i < exp; i++)
            {
                result = result * num;
            }
            return result;
        } //複數的次方
        //改寫
        public override string ToString()
        {   
            if (Imag==0)
                return string.Format("{0:0.####}", Real);
            else if (Real==0)
                return string.Format("{0:0.####}i", Imag);
            else
                return string.Format("{0:0.####}{1}{2:0.####}i",Real,(Imag > 0 ? '+' : '-'),Math.Abs(Imag));
        }  //列印複數
        
    }
}
