namespace Week2
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
            double[] grades = new double[4];

            // collect 4 grades from user
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter A grade: ");
                double grade = GetGrade();
                grades[i] = grade;
            };

            double sum = 0;

            foreach(double grade in grades)
            {
                sum += grade;
            };

            double avg = sum / grades.Length;

            Console.WriteLine(string.Format("You had an average grade of {0}, You got a {1}", avg, LetterGrade(avg)));
        }
    }
}
