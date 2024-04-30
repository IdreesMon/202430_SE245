using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Samplel
{
    class Program
    {
        static void Main(string[] args)
        {
            String strFirst, strOperand, strNum1, strNum2;
            /*Int32 intNum1 = 0, intNum2 = 0, intNum3, intResult = 0;*/
            //added strNum1
            Double dblResult = 0;
            //This part of the code is all of the variables inside the code.

            Console.WriteLine("Hello There!");
            Console.Write("Please enter your first name: ");
            strFirst = Console.ReadLine();

            Console.WriteLine("Hello " + strFirst + "! Let's do some math!");
            Console.Write("Please enter the first number: ");
            strNum1 = Console.ReadLine();

            Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE, POWER): ");
            strOperand = Console.ReadLine().ToUpper(); //user can type in operand in lower or upper case and program wont break

            Console.Write("Please enter the second number: ");
            strNum2 = Console.ReadLine();
           
            double Num1 = double.Parse(strNum1);
            double Num2 = double.Parse(strNum2);

            //This is where the numbers are assigned to the variables
            switch (strOperand)
            {
                case "PLUS":
                    dblResult = Num1 + Num2;
                    Console.WriteLine($"\n\nThe sum of {Num1} and {Num2} equals: {dblResult}");
                    break;
                case "MINUS":
                    dblResult = Num1 - Num2;
                    Console.WriteLine($"\n\nThe difference of {Num1} and {Num2} equals: {dblResult}");
                    break;
                case "DIVIDE":
                    dblResult = Num1 / Num2;
                    Console.WriteLine($"\n\nThe quotient of {Num1} and {Num2} equals: {dblResult}");
                    break;
                case "MULTIPLY":
                    dblResult = Num1 * Num2;
                    Console.WriteLine($"\n\nThe product of {Num1} and {Num2} equals: {dblResult}");
                    break;
                case "POWER":
                    dblResult = Math.Pow(Num1, Num2);
                    Console.WriteLine($"\n\nThe exponent of {Num1} and {Num2} equals: {dblResult}");
                    break;
            }
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}


