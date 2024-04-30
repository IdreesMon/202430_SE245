using System;

namespace ReverseString
{
    class program
    {

        static string ReverseString(string text) //Main Function

        {   //create empty list //Char can store single characters 
            //Console.WriteLine(text);
            //string[] stringArray = Input.stringArray();
            //for(int i = 4; i < text.Length; i--)
            string reversed = "";
            for(int i = text.Length - 1; i >= 0; i--)
            {
        
                //Console.Write(text[i]);
                reversed += text[i];
            }
            return reversed;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input String to be reversed: ");
            string input = Console.ReadLine();
            Console.WriteLine(ReverseString(input));

             //string input = string.empty
            // reversedString = string.empty
            //  Console.WriteLine("Type Hello: ");
            // //string charArray = input.CharArray();
            // string Hello = Console.ReadLine();
            //     //Initialize    //condition      //iterator will go backwards instead of ++
            // for(int i = 0; i < charArray.Length; i--)
            // {
            //     reversedString += string input[i]
            // }
            // Console.WriteLine(charArray[i]);
            

        }




    }
}
