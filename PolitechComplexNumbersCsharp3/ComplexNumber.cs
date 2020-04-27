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
        public ComplexNumber(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getComplexModule()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public String toString()
        {
            return "" + x + "+" + y + "i";
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
            return new ComplexNumber(number1.x * number2.x, number1.y * number2.y);
        }

        public static ComplexNumber divide(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.x / number2.x, number1.y / number2.y);
        }

        public static ComplexNumber pow(ComplexNumber number1, int stage)
        {
            return new ComplexNumber(Math.Pow(number1.x, stage), Math.Pow(number1.y, stage));
        }

    }
}
