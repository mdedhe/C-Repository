using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Getting the range to print the prime number");
              int x = 0, y = 10;
               Console.WriteLine("find the prime numbers between " + x + "and " +y);
              printPrimeNumber(x, y);

              //getting the series output for the number assigned below:-
              int n = 2;
              Console.WriteLine("get the seriesResult for the number = "+n);
              double result =getSerierResults(n);
              Console.WriteLine("Output of the getSeriesResult is = " + result);
              //getting the Binary from decimal number
              long num = 100;
              Console.WriteLine("Selected, decimal to convert it to binary number is = " + num);
              long resultbinary=decimalToBinary(num);
              Console.WriteLine("Binary conversion of the decimal number " + num + " is = " + resultbinary);
            long numb = 1000;
            long resultdec=binaryTodecimal(numb);
            Console.WriteLine("Decimal conversion of the binary number " + numb + " is= " + resultdec);
            int nStar = 5;
            printTriangle(nStar);*/
            int[] arr = {1,1,3,4,2,2,2,2,8,8,6};
            computeFrequency(arr);
        }
        public static void printPrimeNumber(int x, int y) {
            //start the loop between the range
            for (int i = x; i <= y; i++)
            {
                bool isprime = false;
                for (int j = 1; j < x; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = true;
                        break;
                    }
                }
                if (isprime == false)
                {
                    Console.Write(i+" ");
                }
            }
        }
        public static double getSerierResults(int n)
        {
            // declaring the local variable to store the result
            double finaldec = 0;
            //initiating loop to create the series as per the requirement
            for (int i = 1; i <= n; i++) {
                //getting the factorial for the number which comes first
               double fact = getFactorial(i);
                //to create the series making condition statement
                //1 /2-2!/3+3!/4
                if (i % 2 != 0)
                    finaldec += fact / (i + 1);
                else
                    finaldec -= fact / (i + 1);
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
            string bin ="";
            //iterating the number n and divide it to the 2 to get the binary using loop for the same
            long num = n1;
            while (num > 0)
            {
                if (num % 2 == 0)
                    bin +="0";
                else
                    bin += "1";
                num = num / 2;
            }
            char[] c = bin.ToCharArray();
            Array.Reverse(c);
            string s = new string(c);
            long binf = long.Parse(s);
            return binf;
        }
        public static long binaryTodecimal(long n)
        {
            double finaldec = 0;
            int k = 0;
            string binary = n.ToString();
            char[] c = binary.ToCharArray();
            Array.Reverse(c);
            //check if all the character are zero then decimal is also zero
            bool flag = checkAllzero(c);

            if (flag == false)
            {
                foreach (char i in c)
                {
                    string s = char.ToString(i);
                    int a = int.Parse(s);
                    finaldec += a* Math.Pow(2, k);
                    k++;
                }
            }
            long dec = (long)finaldec;
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
            for(int i=0; i<5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void computeFrequency(int[] a)
        {
            int count = 0;
            Array.Sort(a);
            for (int i = 0; i < a.Length-1; i++)
            {
                count++;
                if (a[i] != a[i + 1])
                { 
                    Console.WriteLine(a[i] + " frequency is = " + count);
                    count = 0;
                }
            }
        }

    }
}