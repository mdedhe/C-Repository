using System;

namespace ClassExcercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating the variable for storing the sum of all the numbers.
            int sum = 0;
            Console.WriteLine("Get the sum for all the natural numbers.");
            Console.WriteLine("Please enter the number till you want to do the sum.");
            string number = Console.ReadLine();
            //parsing the string into integer
            int num = int.Parse(number);
            while (num > 0) {
                sum = sum + num;
                num--;
            }
            //Final output will be the sum of the number
            Console.WriteLine("Sum of the numbers is = "+sum);
        }
    }
}
