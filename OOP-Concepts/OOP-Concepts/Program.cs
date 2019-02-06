using System;

namespace OOP_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ps = new Person();
            ps.firstName = "Mohit";
            ps.lastName = "Dedhe";
            Console.WriteLine("My Name is " + ps.getName());
            Console.ReadKey(true);
        }
    }
}
