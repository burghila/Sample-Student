using System;

// Define the namespace for the application
namespace AbstractClassDemo
{
    // Define an abstract class called Person
    public abstract class Person
    {
        // Public properties for first and last names
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Abstract method SayName to be implemented by any derived classes
        public abstract void SayName();
    }

    // Define a class Employee that inherits from Person
    public class Employee : Person
    {
        // Implement the SayName method to display the full name of the employee
        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }

    // Main class where the program execution starts
    class Program
    {
        // Main method - the entry point of the application
        static void Main(string[] args)
        {
            // Instantiate an Employee object and initialize it
            Employee emp = new Employee() { firstName = "Sample", lastName = "Student" };

            // Call the SayName method on the Employee object
            emp.SayName();

            // Prevent the console from closing immediately
            Console.ReadLine();
        }
    }
}
