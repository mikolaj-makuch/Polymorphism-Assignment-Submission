using System;

namespace Polymorphism_Assignment_Submission
{
    // Define the IQuittable interface
    public interface IQuittable
    {
        void Quit();
    }

    // Implement the IQuittable interface in a class
    public class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Employee is quitting the job.");
        }
    }
}