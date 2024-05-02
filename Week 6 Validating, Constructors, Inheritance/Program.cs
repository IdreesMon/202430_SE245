using System;

namespace Week_6_Validating_Constructors_Inheritance
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string email;
        private string zipCode;
        private string streetOne;
        private string streetTwo;
        private DateTime dateOfBirth;
        private string feedback = "";
        private static Regex emailRegex = new Regex("^\\S+@\\S+\\.\\S+$");

        public Person(string FirstName, string MiddleName, string LastName, string Email, string ZipCode, string StreetOne, string StreetTwo, DateTime DateOfBirth)
        {
            firstName = FirstName;
            middleName = MiddleName;
            lastName = LastName;
            email = Email;
            zipCode = ZipCode;
            streetOne = StreetOne;
            streetTwo = StreetTwo;
            dateOfBirth = DateOfBirth;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!Person.emailRegex.IsMatch(value))
                {
                    feedback = ("Enter a Valid Email");
                }
                else
                {
                    email = value;
                }
            }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string StreetOne
        {
            get { return streetOne; }
            set { streetOne = value; }
        }
        public string StreetTwo
        {
            get { return streetTwo; }
            set { streetTwo = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Feedback
        {
            get { return feedback; }
        }

    }
    {
        //Create Person V2 class inherited from Person
        public class PersonV2 : Person
        {
            private string phoneNumber;
            private string feedback = "";
            private static Regex phoneRegex = new Regex("^\\d{3}-\\d{3}-\\d{4}$");

            public PersonV2(string FirstName, string LastName, string Email, DateTime DateOfBirth, string PhoneNumber) : base(FirstName, LastName, Email, DateOfBirth)
            {
                phoneNumber = PhoneNumber;
            }

            public string PhoneNumber
            {
                get { return phoneNumber; }
                set
                {
                    if (!PersonV2.phoneRegex.IsMatch(value))
                    {
                        feedback = ("Enter a Valid Phone Number");
                    }
                    else
                    {
                        phoneNumber = value;
                    }
                }
            }

            public string Feedback
            {
                get { return feedback; }
            }
        }


        // static void Main(string[] args)
        // {
        //     Console.WriteLine("Hello World!");
        // }
    }
}