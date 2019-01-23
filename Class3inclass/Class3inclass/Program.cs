using System;

namespace Class3inclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age. You must be between 18 and 100.");
            try
            {
                String age_str = Console.ReadLine();
                int age = int.Parse(age_str);
                if ((age >= 17) && (age <= 100))
                {
                    int max_heart_rate = get_max_heart_rate(age);
                    Console.WriteLine("Your max heart rate is " + max_heart_rate);
                    Recommend_Exercise(max_heart_rate);
                }
                Console.WriteLine("Press any key to rerun the program.");
                Console.ReadKey(true);
            }//end of try
            catch
            {
                Console.WriteLine("Enter your age. It should be between 18 and 100.");
                Console.WriteLine("Press any key to rerun the program.");
                Console.ReadKey(true);
            }//end of catch


        }//end of static method 

        private static int get_max_heart_rate(int age)
        {
            int calc_max_heart_rate = 220 - age;
            Console.WriteLine("Based on the age you entered: " + age);
           // Console.WriteLine("Your maximum heart rate during exercise should be " + calc_max_heart_rate);
            return calc_max_heart_rate;
        }//End of the get_max_heart_rate
        public static void Recommend_Exercise(int hr_rate)
        {
            //calculate the recommended lower target heart rate
            double lower_rec_execercise = hr_rate * .55;

        }
    }
}
