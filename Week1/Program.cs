﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Samplel {
    class Program {
        static void Main (string[] args) {
            String strFirst, strOperand, strNum1, strNum2;
            Int32 intNum1 = 0, intNum2 = 0, intNum3, intResult = 0;
            //added strNum1
            Double dblResult = 0;
//This part of the code is all of the variables inside the code.
            Console.WriteLine ("Hello There!");

            Console.Write ("Please enter your first name: ");
            strFirst = Console.ReadLine ();

            Console.WriteLine ("Hello " + strFirst + "! Let's do some math!");

            Console.Write ("Please enter the first number: ");
            strNum1 = Console.ReadLine ();

            Console.Write ("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE, POWER): ");
            strOperand = Console.ReadLine().ToUpper(); //user can type in operand in lower or upper case and program wont break

            Console.Write ("Please enter the second number: ");
            strNum2 = Console.ReadLine ();
//This part of the code is the main area in which we are looking at the code grab all the numbers from the user and which symbol they want to use
            double Num1 = Int32.Parse (strNum1);
            double Num2 = Convert.ToInt32 (strNum2);
//This is where the numbers are assigned to the variables
            switch (strOperand) {
                case "PLUS":
                    dblResult = intNum1 + intNum2;
                    Console.WriteLine ($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
                    break;

                case "MINUS":
                    dblResult = intNum1 - intNum2;
                    Console.WriteLine ($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
                case "DIVIDE":
                    dblResult = intNum1 / intNum2;
                    Console.WriteLine ($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
                case "MULTIPLY":
                    dblResult = intNum1 * intNum2;
                     Console.WriteLine ($"\n\nThe product of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
                case "POWER":
                    dblResult = Math.Pow (intNum1, intNum2);
                    Console.WriteLine ($"\n\nThe exponent of {intNum1} and {intNum2} equals: {dblResult}");
                    break;

       
             dblResult = (Double) intResult;
            
                
        
                    //This is where the code was missing an original place to initalize the MULTIPLY statement and was needing it
            }
//This part of the code is where the math is calculated by checking which operation was choosen by the user and then placed into it. 
            dblResult = (Double) intResult;

            if (strOperand == "PLUS")
                Console.WriteLine ($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "MINUS")
                Console.WriteLine ($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "DIVIDE")
                Console.WriteLine ($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "MULTIPLY")
                Console.WriteLine ($"\n\nThe product of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "POWER")
                Console.WriteLine ($"\n\nThe exponent of {intNum1} and {intNum2} equals: {dblResult}");
//Added where I should put the place to solve the mulitplication problem intialize it. Multipling the variables together.
//This part of the code prints the solution to the problem and which operator you chose. once it figures that out it then prints the proper statement.
            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
        }
    }
}


