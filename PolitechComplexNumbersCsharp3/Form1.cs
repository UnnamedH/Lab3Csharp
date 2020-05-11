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
            double ComplexField1 = Double.Parse(complexNumField1.Text);
            double ImagField1 = Double.Parse(ImagNumField1.Text);
            double ComplexField2 = Double.Parse(complexNumField2.Text);
            double ImagField2 = Double.Parse(ImagNumField2.Text);
            double ComplexField3 = Double.Parse(complexNumField3.Text);
            double ImagField3 = Double.Parse(ImagNumField3.Text);
            ComplexNumber complexNumber1 = new ComplexNumber(ComplexField1, ImagField1);
            ComplexNumber complexNumber2 = new ComplexNumber(ComplexField2, ImagField2);
            ComplexNumber complexNumber3 = new ComplexNumber(ComplexField3, ImagField3);
            printResults(complexNumber1);
            printResults(complexNumber2);
            printResults(complexNumber3);
            printFormula(complexNumber1, complexNumber2, complexNumber3);
        }

        void printResults(ComplexNumber complex)
        {
            labelModule.Text = "Модуль: " + complex.getComplexModule();
            labelImagNum.Text = "Комплексная запись: " + complex;
        }

        void printFormula(ComplexNumber complex1, ComplexNumber complex2, ComplexNumber complex3)
        {
            labelFormula.Text = "Модуль числа X: " + ((pow(complex1,4)) + ((complex1 - complex2)/(complex3*complex1))).getComplexModule();
        }
    }
}
