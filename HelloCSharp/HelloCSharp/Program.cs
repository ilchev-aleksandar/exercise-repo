using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string operator1 = Console.ReadLine();
            switch (operator1)
            {
                case "+":
                    double result = 0;
                    result = number2 + number1;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} + {1} = {2} - even", number1, number2, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} + {1} = {2} - odd", number1, number2, result);
                    }
                    break;
                case "-":
                    double result1 = 0;
                    result1 = Math.Abs(number2 - number1);
                    if (result1 % 2 == 0)
                    {
                        Console.WriteLine("{0} - {1} = {2} - even", number1, number2, result1);
                    }
                    else
                    {
                        Console.WriteLine("{0} - {1} = {2} - odd", number1, number2, result1);
                    }
                    break;
                case "*":
                    double result2 = 0;
                    result2 = number1 * number2;
                    if (result2 % 2 == 0)
                    {
                        Console.WriteLine("{0} * {1} = {2} - even", number1, number2, result2);
                    }
                    else
                    {
                        Console.WriteLine("{0} * {1} = {2} - odd", number1, number2, result2);
                    }
                    break;
                case "/":


                    if (number2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", number1);
                    }
                    else
                    {
                        double result3 = number1 / number2;
                        Console.WriteLine("{0} / {1} = {2:f2}", number1, number2, result3);
                    }
                    break;
                case "%":
                    if (number2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", number1);
                    }
                    else
                    {
                        double result4 = number1 % number2;
                        Console.WriteLine("{0} % {1} = {2}", number1, number2, result4);
                    }

                    break;

            }


            }
        }
}
