using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;

class Program
{
    public delegate int IntDelegate(double d);
    public delegate double CalcDelegate(double x, double y);
    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public static double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mult(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            throw new DivideByZeroException();
        }
    }

    static void Main()
    {
        Calculator calculator = new();
        while (true)
        {
            WriteLine("Enter");

            string exp = ReadLine();
            char sign = ' ';

            foreach (char sym in exp)
            {
                if (sym == '+' || sym == '-' || sym == '*' || sym == '/')
                {
                    sign = sym;
                    break;
                }
            }
            try
            {
                string[] numb = exp.Split(sign);
                CalcDelegate del = null;

                switch (sign)
                {
                    case '+':
                        del = new CalcDelegate(calculator.Add);
                        break;
                    case '-':
                        del = new CalcDelegate(Calculator.Sub);
                        break;
                    case '*':
                        del = calculator.Mult;
                        break;
                    case '/':
                        del = calculator.Div;
                        break;
                    default:
                        throw new InvalidOperationException();

                }
                double a = double.Parse(numb[0]);
                double b = double.Parse(numb[1]);

                WriteLine($"Result: {del(a, b)}");

            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }

        
        }

}


