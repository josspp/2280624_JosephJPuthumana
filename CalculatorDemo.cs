using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Day_8
{
    internal class CalculatorDemo
    {
        public static void Main()
        {
            Calculator obj = new Calculator();
            Console.WriteLine("Sum from another assembly");
            Console.WriteLine(obj.Sum(1, 2));
        }
    }
}