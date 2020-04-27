using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolitechComplexNumbersCsharp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            complexNumField1.DecimalPlaces = 1;
            ImagNumField1.DecimalPlaces = 1;
            complexNumField2.DecimalPlaces = 1;
            ImagNumField2.DecimalPlaces = 1;
            complexNumField3.DecimalPlaces = 1;
            ImagNumField3.DecimalPlaces = 1;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            double ComplexField = Double.Parse(complexNumField1.Text);
            double ImagField = Double.Parse(ImagNumField1.Text);
            ComplexNumber complexNumber1 = new ComplexNumber(ComplexField, ImagField);
            ComplexNumber complexNumber2 = new ComplexNumber(ComplexField, ImagField);
            ComplexNumber complexNumber3 = new ComplexNumber(ComplexField, ImagField);
            printResults(complexNumber1);
            printResults(complexNumber2);
            printResults(complexNumber3);
            printFormula(complexNumber1, complexNumber2, complexNumber3);
        }

        void printResults(ComplexNumber complex)
        {
            labelModule.Text = "Модуль: " + complex.getComplexModule();
            labelImagNum.Text = "Комплексная запись: " + complex.toString();
        }

        void printFormula(ComplexNumber complex1, ComplexNumber complex2, ComplexNumber complex3)
        {
            
            labelFormula.Text = "Модуль числа X: " + ComplexNumber.add(ComplexNumber.pow(complex2, 4),ComplexNumber.divide(ComplexNumber.substract(complex1, complex2), ComplexNumber.divide(complex3, complex1))).toString();
        }
    }
}
