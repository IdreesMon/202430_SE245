//Week 4 Lab

using System;
namespace PersonStruct
{
    class Helper
    {    //Within this helper class we have a few methods that will help us get user input.
            
            

        static public string AskStringQuestion(string question) //The first method is AskStringQuestion which takes a string as a parameter 
        {
            Console.Write($"{question}: ");
            return Helper.GetString();
        }

        static public int AskIntQuestion(string question) //The second method is AskIntQuestion which takes a string as a parameter
        {       //This method will ask the user a question and then return the user's input as an integer.
            Console.Write($"{question}: ");
            return Helper.GetInt();
        }

        static public string GetString()
        {    //This method will get the user's input as a string and return it.
             //string? is a nullable string, which means it can be null.
            string? output = null;
            do
            {
                string? userInput = Console.ReadLine();

                if (userInput == null)
                {   //If the user's input is null, we will ask the user to try again.
                    Console.Write("Bad Input, try again: ");
                }
                else
                {   //If the user's input is not null, we will set the output variable to the UserInput.
                    output = userInput;
                }
            } while (output == null); //We will continue to ask the user for input until the output is not null.

            return output;
        }

        static public int GetInt() //This method will get the user's input as an integer and return it.
        {
            int output;
            bool successful; // here we will use a boolean variable to determine if the user's input was successful.

            do
            {
                string userInput = Helper.GetString();

                successful = int.TryParse(userInput, out output); //We will try to parse the user's input as an integer and set the output variable to the result.
                if (!successful)
                {
                    Console.Write("Bad Input, try again: ");
                }
                else
                {

                }
            } while (!successful);

            return output;
        }
    }
    class Person
    {   //a class called Person that has several properties.
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _streetOne;
        private string _streetTwo;
        private string _city;
        private string _state;
        private int _zip;
        private string _emailAddress;
        private string _phoneNumber;
        //The Person class has a constructor that takes several parameters and sets the properties of the class to the values of the parameters.
        public Person(
            string firstName,
            string middleName,
            string lastName,
            string streetOne,
            string streetTwo,
            string city,
            string state,
            int zip,
            string emailAddress,
            string phoneNumber
        )
        {
            _firstName = firstName + "poopy";
            _middleName = middleName;
            _lastName = lastName;
            _streetOne = streetOne;
            _streetTwo = streetTwo;
            _city = city;
            _state = state;
            _zip = zip;
            _emailAddress = emailAddress;
            _phoneNumber = phoneNumber;
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                Console.WriteLine("updating name!");
                _firstName = value;
            }
        }
        //PUBLIC VARIABLES GETTERS AND SETTERS
        public string MiddleName
        {
            get => _middleName;
            set
            {
                _middleName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
            }
        }

        public string StreetOne
        {
            get => _streetOne;
            set
            {
                _streetOne = value;
            }
        }

        public string StreetTwo
        {
            get => _streetTwo;
            set
            {
                _streetTwo = value;
            }
        }

        public string City
        {
            get => _city;
            set
            {
                _city = value;
            }
        }

        public string State
        {
            get => _state;
            set
            {
                _state = value;
            }
        }

        public int ZIP
        {
            get => _zip;
            set
            {
                _zip = value;
            }
        }

        public string EmailAddress
        {
            get => _emailAddress;
            set
            {
                _emailAddress = value;
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
            }
        }
    }

    class Program
    {           //MAIN METHOD BELOW
                //In the Main method, we will create a new Person object and set its properties to the values of the user's input.
        static void Main(string[] args)
        {
            Person slater = new(
                Helper.AskStringQuestion("First Name"),
                Helper.AskStringQuestion("Middle Name"),
                Helper.AskStringQuestion("Last Name"),
                Helper.AskStringQuestion("Street One"),
                Helper.AskStringQuestion("Street Two"),
                Helper.AskStringQuestion("City"),
                Helper.AskStringQuestion("State"),
                Helper.AskIntQuestion("ZIP code"),
                Helper.AskStringQuestion("Email"),
                Helper.AskStringQuestion("Phone Number")
            ); ; ;

            Console.WriteLine(slater.FirstName);
            slater.FirstName = "xxxx";
            Console.WriteLine(slater.FirstName);
        }
    }
}