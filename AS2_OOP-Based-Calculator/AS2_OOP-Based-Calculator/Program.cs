using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Calculator
{
    // Base class (Parent)
    class Calculator
    {
        protected double num1, num2;

        // Constructor
        public Calculator(double a, double b)
        {
            num1 = a;
            num2 = b;
        }

        // Function Overloading: Add method with different parameters
        public double Add() => num1 + num2;
        public double Add(double a, double b) => a + b;

        // Virtual Method for Polymorphism
        public virtual double Calculate() => 0;
    }

    // Derived class for Addition
    class Addition : Calculator
    {
        public Addition(double a, double b) : base(a, b) { }

        // Overriding method for Polymorphism
        public override double Calculate() => num1 + num2;
    }

    // Derived class for Subtraction
    class Subtraction : Calculator
    {
        public Subtraction(double a, double b) : base(a, b) { }
        public override double Calculate() => num1 - num2;
    }

    // Derived class for Multiplication
    class Multiplication : Calculator
    {
        public Multiplication(double a, double b) : base(a, b) { }
        public override double Calculate() => num1 * num2;
    }

    // Derived class for Division with Error Handling
    class Division : Calculator
    {
        public Division(double a, double b) : base(a, b) { }

        public override double Calculate()
        {
            try
            {
                if (num2 == 0)
                    throw new DivideByZeroException("Error: Cannot divide by zero!");
                return num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return double.NaN; // Return NaN to indicate an error
            }
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nChoose operation: +, -, *, /");
                char operation = char.ToUpper(Console.ReadKey().KeyChar);

                Calculator calc = null;

                switch (operation)
                {
                    case '+': calc = new Addition(num1, num2); break;
                    case '-': calc = new Subtraction(num1, num2); break;
                    case '*': calc = new Multiplication(num1, num2); break;
                    case '/': calc = new Division(num1, num2); break;
                    default: Console.WriteLine("\nInvalid operation!"); return;
                }

                Console.WriteLine($"\nResult: {calc.Calculate()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Invalid input! Please enter numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nUnexpected Error: {ex.Message}");
            }
        }
    }
}

