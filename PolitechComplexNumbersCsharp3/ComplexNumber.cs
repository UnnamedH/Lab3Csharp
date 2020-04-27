using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitechComplexNumbersCsharp3
{
    public class ComplexNumber
    {
        public double x, y;
        public ComplexNumber(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getComplexModule()
        {
            return Math.Sqrt(x * x + y * y);
        }

        override public String ToString()
        {
            return "" + x + "+" + y + " * i";
        }

        public static ComplexNumber add(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.x + number2.x, number1.y + number2.y);
        }

        public static ComplexNumber substract(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.x - number2.x, number1.y - number2.y);
        }

        public static ComplexNumber multiply(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber((number1.x * number2.x) - (number1.y * number2.y),
                                    (number1.x * number2.y)  * (number2.x * number1.y));
        }

        public static ComplexNumber divide(ComplexNumber number1, ComplexNumber number2)
        {
            double mod2 = number2.x * number2.x + number2.y * number2.y;
            return new ComplexNumber((number1.x * number2.x + number1.y * number1.y) / mod2,
                (number1.y * number2.x - number1.x * number2.y) / mod2);
        }

        public static ComplexNumber pow(ComplexNumber number, int stage)
        {
            ComplexNumber result = new ComplexNumber(1, 0);
            for(int i=0; i < stage; i++)
            {
                result = result * number;
            }
            

            return result;
        }

        public static ComplexNumber operator +(ComplexNumber number1, ComplexNumber number2)
        {
            return add(number1, number2);
        }

        public static ComplexNumber operator -(ComplexNumber number1, ComplexNumber number2)
        {
            return substract(number1, number2);
        }

        public static ComplexNumber operator *(ComplexNumber number1, ComplexNumber number2)
        {
            return multiply(number1, number2);
        }

        public static ComplexNumber operator /(ComplexNumber number1, ComplexNumber number2)
        {
            return divide(number1, number2);
        }


        public static ComplexNumber operator ^(ComplexNumber number1, int stage)
        {
            return pow(number1, stage);
        }
    }
}
