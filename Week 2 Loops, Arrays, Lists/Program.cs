using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Asks users to enter a number of students, or handle the number of students dynamically.

//2. For each student, enter a name and 5 lab grades. 

//3. Display each student with each average grade for their 5 labs, and their letter grade. 

//4. Drop down a line or two, and then display the average for each lab #.  (Average grade on Lab #1 for all students)


namespace Week2_LoopsArraysLists 
{
    
    class Program 
    {
        static string LetterGrade(double grade)
        {
            // a = 90 - 100
            // b = 80 - 89
            // c = 70 - 79
            // d = 60 - 69
            // f

            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >=70)
            {
                return "C";
            }
            else if (grade >=60)
            {
                return "D";
            }
            else 
            {
                return "F";
            };
        }
        static string GetFirstName()
        {
            Console.Write("Enter Students First Name: ");
            return Console.ReadLine();
        }
        static string GetLastName()
        {
            Console.Write("Enter Students Last Name: ");
            return Console.ReadLine();
        }

        static int GetInt()
        {
            string? input = Console.ReadLine();

            if (input == null)
            {
                Console.Write("Bad: ");
                return GetInt();
            };

            bool ok = int.TryParse(input, out int results);
            if (!ok)
            {
                Console.Write("Bad: ");
                return GetInt();
            }

            return results;
        }

        static double GetGrade()
        {   
            // makes sure user input is a valid string
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.Write("Bad input, try again: ");
                return GetGrade();
            };

            bool ok = double.TryParse(input, out double grade);
            if (!ok)
            {
                Console.Write("Bad input, try again: ");
                return GetGrade();
            };

            // || = or
            // && = and
            if (grade > 100 || grade < 0)
            {
                Console.Write("Not a proper grade, try again: ");
                return GetGrade();
            };

            return grade;
        }
        static void Main(string[] args)
        {
            List<string> firstNames = new();
            List<string> lastNames = new();
            List<double> gradeAverages = new();

            Console.Write("How many students? ");
            int numberOfStudents = GetInt();

            Console.WriteLine(numberOfStudents);

            //  initial     condition             iterator
            for (int i = 0; i < numberOfStudents; i++ )
            {
                firstNames.Add(GetFirstName());
                lastNames.Add(GetLastName());

                double sum = 0;

                for (int j = 0; j < 5; j++)
                {
                    Console.Write(string.Format("Enter grade #{0}: ", j+1));
                    sum += GetGrade();
                };

                gradeAverages.Add(sum / 5);
            }

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine(
                    string.Format(
                        "Student Name: {0} {1} | Grade Average: {2}", firstNames[i], lastNames[i], gradeAverages[i]
                    )
                    // f"Student Name: {firstNames[i]} {lastNames[i]} | Grade Average: {gradeAverages[i]}"
                );
            };

            Console.ReadKey();
        }
    }
}
    
    