namespace Week4_Class1
{
    //PART 1
    public class PersonStruct
    { 
        private string First;
        private string Middle;
        private string Last;
        private string Street1;
        private int Street2;
        private string City;
        private int State;

        private string Zip;
        private string Phone;
        private string Email;
    }

        public PersonStruct(string title, string authFirst, string authLast, string email, int datePublic, int price, int pages)
        {
            Title = title;
            AuthFirst = authFirst;
            AuthLast = authLast;
            Email = email;
            DatePublic = datePublic;
            Price = price;
            Pages = pages;
        }
}
    class Program
    {
        public static void Main(string[] args)
        {
            BookItemStruct newBook = new BookItemStruct(
                "The Great Gatsby",
                "F. Scott",
                "Fitzgerald",
                "x@gmail.com",
                1925,
                10,
                180
            );

            Console.WriteLine(newBook.Title);
        }

}