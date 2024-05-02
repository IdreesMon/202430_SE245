// namespace Week_6_Palindrom
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a word or phrase to check if it is a palindrome: ");
//             string input = Console.ReadLine();
//             string inputLower = input.ToLower();
//             string inputReversed = "";
//             for (int i = inputLower.Length - 1; i >= 0; i--)
//             {
//                 inputReversed += inputLower[i];
//             }
//             if (inputLower == inputReversed)
//             {
//                 Console.WriteLine("The word or phrase is a palindrome.");
//             }
//             else
//             {
//                 Console.WriteLine("The word or phrase is not a palindrome.");
//             }
//         }
//     }
// }
namespace Week_6_Palindrom
{
    class Program
    {
        static bool IsPalindrome (string word){
        
            for (int i = 0; i <= (word.Length - 1) / 2; i++){
            
                    Console.WriteLine (word[i]);
                    Console.WriteLine (word[word.Length - 1 - i]);
            
                    if (word[i] != word[word.Length - 1 - i]){
                
                    return false;
                }
            }
            return true;
        
        }
            
        
        static void Main(string[] args)
        {
            Console.WriteLine ("Hello World!");
            Console.WriteLine(IsPalindrome("testw"));
            Console.WriteLine(IsPalindrome("Hannah"));
            Console.WriteLine(IsPalindrome("hanonah"));
        }
    }
}
