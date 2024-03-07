using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an object of type Employee
            Employee employee = new Employee();

            // Use polymorphism: treat the employee object as IQuittable
            IQuittable quittableEmployee = employee;

            // Call the Quit method on the IQuittable object
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}