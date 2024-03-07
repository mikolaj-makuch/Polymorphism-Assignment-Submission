using System;

namespace Abstract_Class_Assignment
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public abstract void SayName();
    }
}