using System;

namespace ClassExcercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input the number from user and check whether it is even or odd

            Console.WriteLine("Enter the Number ");
            string num = Console.ReadLine();
            Console.WriteLine("Checking whether number is even Or odd ");
            try
            {
                int number = int.Parse(num);
                if (number % 2 == 0)
                {
                    Console.WriteLine("Given number is even = " + number);
                }
                else
                {
                    Console.WriteLine("Given number is odd = " + number);
                }
            }
            catch (NotFiniteNumberException e)
            {
                Console.WriteLine("Given character should be the number.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("Please rerun the program for the next attempt.");
            }
        }
    }
}
