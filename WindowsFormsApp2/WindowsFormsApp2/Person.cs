using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Person
    {
        private string _firstname;
        private string _middlename;
        private string _lastname;
        private string _phonenumber;
        private string _email;
        private string _streetone;
        private string _streettwo;
        private string _city;
        private string _state;
        private string _zipcode;
        private DateTime _dateOfBirth;
        private static Regex emailRegex = new Regex("^\\S+@\\S+\\.\\S+$");

        public Person(string FirstName, string MiddleName, string LastName, string PhoneNumber, string Email, string StreetOne, string StreetTwo, string City, string State, string ZipCode, DateTime DateOfBirth)
        {
            _firstname = FirstName;
            _middlename = MiddleName;
            _lastname = LastName;
            _phonenumber = PhoneNumber;
            _email = Email;
            _streetone = StreetOne;
            _streettwo = StreetTwo;
            _city = City;
            _state = State;
            _zipcode = ZipCode;
            _dateOfBirth = DateOfBirth;

        }

        public List
            <string> Catch
        { get; private set; } = new List<string>();


        public virtual string GetFeedBack()
        {
            return $"Name: {_firstname} {_middlename} {_lastname}\n" + $"Address: {_streetone} {_streettwo} {_city} {_state} {_zipcode}" + $"Email: {_email}\n" + $"Phone Number: {_phonenumber}\n";

        }

        public bool CatchError()
        {
            return Catch.Count > 0;
        }

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public String MiddleName
        {
            get { return _middlename; }
            set { _middlename = value; }
        }
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public string PhoneNumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string StreetOne
        {
            get { return _streetone; }
            set { _streetone = value; }
        }
        public string StreetTwo
        {
            get { return _streettwo; }
            set { _streettwo = value; }
        }
        public string ZipCode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

    }
}
