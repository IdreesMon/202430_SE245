namespace Week4_Class1
{
    class Program
    {
        public class BookItemStruct
        {
            public string Title;
            public string AuthFirst;
            public string AuthLast;
            public string Email;
            public int DatePublic;
            public int Price;
            public int Pages;

            public BookItemStruct(string title, string authFirst, string authLast, string email, int datePublic, int price, int pages)
            {
                Title = title;
                AuthFirst = authFirst;
                AuthLast = authLast;
                Email = email;
                DatePublic = datePublic;
                Price = price;
                Pages = pages;
            }
            static void Main(string[] args)
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
    }
}