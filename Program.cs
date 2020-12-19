using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(53, 28);
            string s = calc.WriteText("Hello World!");
            Console.WriteLine(s);

            string n = calc.WriteNumber(calc.operand1 + calc.operand2);
            Console.WriteLine(n);

            Console.Read();

        }
    }

    class Calculator
    {
        public  string WriteText(string a)
        {
            return a;
        }

        public  string WriteNumber(int b)

        {
            return b.ToString();
        }
       public int operand1;
      public int operand2;

        public Calculator(int operend1, int operend2)
            {this.operand1 = operend1;
            this.operand2 = operend2;}




             


    }


}