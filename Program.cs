using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber, factorial = 1, i;
            Console.Write("Enter a number : ");
            inputNumber = int.Parse(Console.ReadLine());

            for (i = 1; i <= inputNumber; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial of " + inputNumber + " is " + factorial);
        }
    }
}
