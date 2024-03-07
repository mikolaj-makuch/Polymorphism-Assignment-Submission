using System;

namespace Abstract_Class_Assignment
{
    // Add the necessary using directive for the namespace where IQuittable is defined
    using Polymorphism_Assignment_Submission;

    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        // Implementing the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Employee ID: " + ID + " has quit the job.");
        }

        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
