using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double y = 10;
            byte a = 3;
            string b = "str";

            Console.WriteLine(a + b);
            Console.WriteLine(x * y);
            Console.WriteLine(y - a);
            Console.WriteLine(x / a);

            Console.WriteLine("Enter first number: ");
            double inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double inputNumber2 = Convert.ToInt32(Console.ReadLine());

            double result1 = -6 * Math.Pow(inputNumber, 3) + 5 * Math.Pow(inputNumber, 2) - 10 * inputNumber + 15;
            Console.WriteLine($"-6*{inputNumber}^3+5*{inputNumber}^2-10*{inputNumber}+15 = {result1}");

            double result2 = Math.Abs(inputNumber) * Math.Sin(inputNumber);
            Console.WriteLine($"abs({inputNumber})*sin({inputNumber}) = {result2}");

            double result3 = 2 * Math.PI * inputNumber;
            Console.WriteLine($"2*pi*{inputNumber} = {result3}");


            double result4 = Math.Max(inputNumber, inputNumber2);
            Console.WriteLine($"max({inputNumber}, {inputNumber2}) = {result4}");
        }
    }
}
