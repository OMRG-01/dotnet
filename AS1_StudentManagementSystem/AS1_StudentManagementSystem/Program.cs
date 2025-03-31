using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS1_StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool exist = false;

            while (!exist)
            {
                Console.WriteLine("\n===== Student Management System =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ViewStudents();
                        break;
                    case "3":
                        exist = true;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

            }
        }

        static void AddStudent()
        {
            Console.Write("\nEnter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.Write("Invalid input! Enter a valid age: ");
            }

            Console.Write("Enter Student Grade (A/B/C/D/F): ");
            char grade = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            string studentData = $"Name: {name}, Age: {age}, Grade: {grade}";

            File.AppendAllText("students.txt", studentData + Environment.NewLine);

            Console.WriteLine("\nStudent added successfully!");
        }

        static void ViewStudents()
        {
            if (File.Exists("students.txt"))
            {
                string[] students = File.ReadAllLines("students.txt");
                Console.WriteLine("\n===== Student List =====");
                foreach (string student in students)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("\nNo student records found.");
            }
        }

    }
}
