using System;

namespace OOP_EmployeeApp
{
    // Step 1: Define an Interface
    interface IWork
    {
        void DisplayWork(); // Method to be implemented by classes
    }

    // Step 2: Create a Base Class (Person)
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Public Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person Constructor Called");
        }

        // Virtual Method (Can be Overridden)
        public virtual void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        // Static Constructor (Called once for the class)
        static Person()
        {
            Console.WriteLine("Static Constructor: Person Class Initialized");
        }
    }

    // Step 3: Create a Derived Class (Employee)
    class Employee : Person, IWork
    {
        public int EmployeeID { get; set; }
        public string Department { get; set; }

        // Public Constructor
        public Employee(string name, int age, int empID, string dept) : base(name, age)
        {
            EmployeeID = empID;
            Department = dept;
            Console.WriteLine("Employee Constructor Called");
        }

        // Overriding Base Class Method
        public override void ShowDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}, Name: {Name}, Age: {Age}, Department: {Department}");
        }

        // Implementing Interface Method
        public void DisplayWork()
        {
            Console.WriteLine($"{Name} works in {Department} department.");
        }

        // Method Hiding (Using `new`)
        public new void ShowBaseDetails()
        {
            base.ShowDetails(); // Calling Base Class Method
        }
    }

    // Step 4: Main Program Execution
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Employee Management System =====");

            // Taking User Input
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.Write("Invalid input! Enter a valid age: ");
            }

            Console.Write("Enter Employee ID: ");
            int empID;
            while (!int.TryParse(Console.ReadLine(), out empID) || empID <= 0)
            {
                Console.Write("Invalid input! Enter a valid Employee ID: ");
            }

            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();

            // Creating Employee Object with User Input
            Employee emp = new Employee(name, age, empID, dept);

            Console.WriteLine("\n->Overriding ShowDetails() Output:");
            emp.ShowDetails(); // Calls Overridden Method

            Console.WriteLine("\n->Calling Base Class ShowDetails() Using Method Hiding:");
            emp.ShowBaseDetails(); // Calls Base Class Method

            Console.WriteLine("\n-> Interface Method Implementation:");
            emp.DisplayWork(); // Calls Interface Method

            Console.WriteLine("\n===== End of Program =====");
        }
    }
}
