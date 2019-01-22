using System;

namespace ClassExcercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //highest number 
            int highest = 0;
            //Input three numbers from the user and check the greatest of them.
            Console.WriteLine("Input three numbers from the user and check the greatest of them.");
            Console.WriteLine("write three numbers with spaces ");
            String numbers = Console.ReadLine();
            Console.WriteLine("Checking for the algorithm.");
            //converting the string into number
            string[] num = numbers.Split(" ");
            int[] n = new int[num.Length];

            for (int i = 0; i < n.Length; i++) {
                n[i] = int.Parse(num[i]);
            }
            //checking for the highest number 
            for (int i = 0; i < n.Length-1; i++) {
                if (n[i] > highest)
                {
                    highest = n[i];
                }

            }
            //Final output should be the highest number of the array.
            Console.WriteLine("Highest Number of the input is = " + highest);
        }
    }
}
