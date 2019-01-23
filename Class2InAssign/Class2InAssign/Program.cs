using System;

namespace Class2InAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the integer grade for the class.");
            try
            {
                String gr_st = Console.ReadLine();
                int grade_int = int.Parse(gr_st);
                if (grade_int < 101)
                {
                    string final_grade = GetTheGrade(grade_int);
                    Console.WriteLine("One the basis of your marks, your grade is = " + final_grade);
                }
                else
                {
                    Console.WriteLine("Please enter the number between 0 to 100 for getting the grade.");
                }
            }
            //end of try
            catch {
                Console.WriteLine("Please put the integer to program for running.");
            }
        }//end of static main method;
        private static string GetTheGrade(int grade)
        {
            String grad = "";
            if ((grade >= 95) && (grade <= 100))
            {
                grad = "A+";
            }
            else if ((grade >= 90) && (grade < 95))
            {
                grad = "A";
            }
            else if ((grade >= 87) && (grade < 90))
            {
                grad = "A-";
            }
            else if ((grade >= 84) && (grade < 87))
            {
                grad = "B+";
            }
            else if ((grade >= 80) && (grade < 84))
            {
                grad = "B";
            }
            else if ((grade >= 77) && (grade < 80))
            {
                grad = "B";
            }
            else if ((grade >= 74) && (grade < 77))
            {
                grad = "C+";
            }
            else if ((grade >= 70) && (grade < 74))
            {
                grad = "C";
            }
            else if ((grade >= 67) && (grade < 70))
            {
                grad = "C";
            }
            else if ((grade >= 63) && (grade < 67))
            {
                grad = "D+";
            }
            else if ((grade >= 60) && (grade < 63))
            {
                grad = "D";
            }
            else if ((grade >= 0) && (grade < 60))
            {
                grad = "F";
            }

            return grad;
        }
    }
}
