using System;
//getting to know the library from the https://www.donetperls.com/distinct
using System.Linq;
namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting the range to print the prime number");
            int x = 32, y = 100;
            Console.WriteLine("find the prime numbers between " + x + " and " +y);
            printPrimeNumber(x, y);
              
            //getting the series output for the number assigned below:-
            int n = 4;
            Console.WriteLine("");
            if (n < 0)
            {
                Console.WriteLine("Please give the positive integer to get the sum of series.");
            }
            else
            {
                Console.WriteLine(" get the seriesResult for the number = " + n);
                double result = getSeriesResult(n);
                Console.WriteLine("");
                Console.WriteLine("The sum of the series is: " + result);
            }
            //getting the Binary from decimal number
            long num = 100;
            if (num < 0)
            {
                Console.WriteLine("Kindly use the positive number for conversion.");
            }
            else
            {
                Console.WriteLine("Selected, decimal to convert it to binary number is = " + num);
                long resultbinary = decimalToBinary(num);
                Console.WriteLine("Binary conversion of the decimal number " + num + " is = " + resultbinary);
            }
            
            long numb = 1000;
            if (numb < 0)
            {
                Console.WriteLine("Kindly use the positive number for conversion.");
            }
            else
            {
                long resultdec = binaryTodecimal(numb);
                Console.WriteLine("Binary conversion of the decimal number " + numb + " is= " + resultdec);
            }
            
            int nStar = 4;
            if (nStar <= 1)
            {
                Console.WriteLine("Please give a valid integer to print the triangle.");
            }
            else
            {
                printTriangle(nStar);
            }
           
            int[] arr = {1,1,3,4,2,2,2,2,8,8,9};
            computeFrequency(arr);
        }
        public static void printPrimeNumber(int x, int y) {
            //start the loop between the range
            try
            {
                if (x > y)
                    Console.WriteLine("Please give the valid range for program to run.");
                else
                { 
                    for (int i = x; i <= y; i++)
                        {
                             bool ispri = false;
                             if (i == 0)
                                continue;
                            for (int j = 2; j < i; j++)
                                {
                                    if (i % j == 0)
                                        {
                                               ispri = true;
                                               break;
                                        }
                                }
                            if (ispri == false)
                                {
                                 Console.Write(i + " "); 
                                }
                        }//For loop end
                 }//end of else
            }//end of try
            catch
            {
                Console.WriteLine("Exception occured while computing printprimeNumbers()");
            }//end of catch
        }
        public static double getSeriesResult(int n)
        {
            // declaring the local variable to store the result
            double finaldec = 0;
            try
            {
                //initiating loop to create the series as per the requirement
                for (int i = 1; i <= n; i++)
                {
                    //getting the factorial for the number which comes first
                    double fact = getFactorial(i);
                    //to create the series making condition statement
                    //1 /2-2!/3+3!/4
                    if (i % 2 != 0)
                        finaldec += fact / (i + 1);
                    else
                        finaldec -= fact / (i + 1);
                }//end of FOR loop
            }//end of try
            catch
            {
                Console.WriteLine("Execption occurred while computing getSeriesResult()");
            }
            return Math.Round(finaldec, 3);
        }
        public static int getFactorial(int n)
        {
            int fact = 1;
            while (n > 0)
            {
                fact = fact * n;
                n--;
            }

            return fact;
        }
        public static long decimalToBinary(long n1)
        {
            long binf = 0;
            try
            {
                string bin = "";
                //iterating the number n and divide it to the 2 to get the binary using loop for the same
                long num = n1;
                while (num > 0)
                {
                    if (num % 2 == 0)
                        bin += "0";
                    else
                        bin += "1";
                    num = num / 2;
                }
                char[] c = bin.ToCharArray();
                Array.Reverse(c);
                string s = new string(c);
                binf = long.Parse(s);
            }//end of try
            catch
            {
                Console.WriteLine("Execption occurred while computing decimalToBinary()");
            }//end of catch
            return binf;
        }
        public static long binaryTodecimal(long n)
        {
            double finaldec = 0;
            long dec = 0;
            int k = 0;
            string binary = n.ToString();
            char[] c = binary.ToCharArray();
            Array.Reverse(c);
            //check if all the character are zero then decimal is also zero
            bool flag = checkAllzero(c);
            try
            {
                if (flag == false)
                {
                    foreach (char i in c)
                    {
                        string s = char.ToString(i);
                        int a = int.Parse(s);
                        finaldec += a * Math.Pow(2, k);
                        k++;
                    }
                }
                dec = (long)finaldec;
                
            }//end of try
            catch
            {
                Console.WriteLine("Execption occurred while computing binaryTodecimal()");
            }//end of catch
            return dec;
        }
        public static bool checkAllzero(char[] c)
        {
            bool flagzero = true;
            foreach (char i in c)
            {
                if (i != '0')
                {
                    flagzero = false;
                    return flagzero;
                }
            }
            return flagzero;
        }
        public static void printTriangle(int n)
        {
            try
            {
                int i;
                for (i = 0; i < n + 1; i++)
                {
                    for (int j = n; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int t = 0; t < (2 *i - 1); t++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }//end of try
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
        public static void computeFrequency(int[] a)
        {
            int count = 0;
            try
            {
                Array.Sort(a);
                //1,1,1,3,3,4,5,6,7,7,7,8,8
                //create the distinct array to do the counting

                int[] adis = a.Distinct().ToArray();
                Console.Write("Number ");
                Console.Write("       ");
                Console.Write("Frequency ");
                for (int i = 0; i < adis.Length; i++)
                {
                    //initialize to 0 for the net iteration
                    count = 0;
                    for(int j=0; j<a.Length; j++)
                    {
                        if (adis[i] == a[j])
                        {
                            count++;
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine(adis[i]+ "       "+count);
                    
                }
            }//end of try
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }

        }

    }
}