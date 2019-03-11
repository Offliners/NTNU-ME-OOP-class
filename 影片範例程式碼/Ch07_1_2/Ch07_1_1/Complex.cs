using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07_1_2
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
        
        public Complex Multiply(Complex num)
        {
            Complex result = new Complex(0, 0);
            result.Real = this.Real*num.Real-this.Imag*num.Imag;
            result.Imag = this.Real*num.Imag+this.Imag*num.Real;
            return result;
        }
        public Complex Power(int exp)
        {
            Complex result = new Complex(1, 0);
            if (exp == 0)
                return result;

            for (int i = 0; i < exp; i++)
            {
                result=this.Multiply(result);
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
