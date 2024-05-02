namespace Week6Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
           static string ReverseString(string text) //Main Function

        {  
            string reversed = "";
            for(int i = text.Length - 1; i >= 0; i--)
            {
        
                //Console.Write(text[i]);
                reversed += text[i];
            }
            return reversed;
        }
           
        }
    }
}
