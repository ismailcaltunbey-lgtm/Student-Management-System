using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
    }

    class Program
    {
        static List<Student> studentList = new List<Student>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. List All Students");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                if (choice == "1") AddStudent();
                else if (choice == "2") ListStudents();
                else if (choice == "3") break;
                else Console.WriteLine("Invalid option, please try again.");
            }
        }

        static void AddStudent()
        {
            Student newStudent = new Student();

            Console.Write("Enter ID: ");
            newStudent.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Full Name: ");
            newStudent.FullName = Console.ReadLine();

            Console.Write("Enter Department: ");
            newStudent.Department = Console.ReadLine();

            studentList.Add(newStudent);
            Console.WriteLine("Student added successfully!");
        }

        static void ListStudents()
        {
            Console.WriteLine("\nRegistered Students:");
            Console.WriteLine("ID | Full Name | Department");
            Console.WriteLine("---------------------------");

            foreach (var student in studentList)
            {
                Console.WriteLine($"{student.Id} | {student.FullName} | {student.Department}");
            }
        }
    }
}