using System;

namespace Class3Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer between 1 and 20.");
            try {
                String input = Console.ReadLine();
                int inpt = int.Parse(input);
                if ((inpt > 0) && (inpt <= 10))
                {
                    Console.WriteLine("");
                    int[] arr = { 1, 8, 1, 3, 6, 0, 6, 1, 4, 3, 6 };
                    Console.WriteLine("You have entered the value of input is =" + inpt);
                    Console.WriteLine("The value is " + arr[inpt] + " in element # " + inpt);
                    Console.WriteLine("Here are the values of array :- ");
                    Console.WriteLine("");
                    foreach (int i in arr)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }
                else if ((inpt > 10) && (inpt <= 20))
                {
                    Console.WriteLine("");
                    Console.WriteLine("First , let's automatically populate an array with integers based on the size.");
                    Console.WriteLine("");
                    String value = Console.ReadLine();
                    int val_arr_size = int.Parse(value);
                    //creating the array for the given input
                    int[] arr = new int[val_arr_size];
                    int pop_arr_value = 0;
                   // Console.WriteLine("You have entered the value of input is =" + inpt);
                   // Console.WriteLine("The value is " + arr[inpt] + " in element # " + inpt);
                    Console.WriteLine("Here are the values of array :- ");
                    Console.WriteLine("");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = pop_arr_value;
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("Press any key to exit the program and try again.");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 20.");
                    Console.WriteLine("Press any key to exit the program and try again.");
                    Console.ReadKey(true);
                }

            }//end of try
            catch {
                Console.WriteLine("Please enter an iteger between 1 and 20.");
                Console.ReadKey(true);
            }//end of catch
        }
    }
}
