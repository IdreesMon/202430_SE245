using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace WindowsFormsApp2
{
    internal class PersonV2 : Person
    {
        private static readonly Regex _instagramURLRegex = new Regex(@"instagram\.com/(a-zA-Z0-9._]{1,30})");
        private string _instaUrl;
        private string _cellPhone;


        public PersonV2(

           string FirstName,
           string MiddleName,
           string LastName,
           string PhoneNumber,
           string Email,
           string StreetOne,
           string StreetTwo,
           string ZipCode,
           string City,
           string State,
           DateTime DateOfBirth,
           string InstaUrl,
           string CellPhone
       ) : base(

               FirstName,
               MiddleName,
               LastName,
               PhoneNumber,
               Email,
               StreetOne,
               StreetTwo,
               ZipCode,
               City,
               State,
               DateOfBirth)
        {
            InstaUrl = _instaUrl;
            CellPhone = _cellPhone;

        }

        public override string GetFeedBack()
        {
            return base.GetFeedBack() + $"Cell Phone: {CellPhone}\n" + $"Instagram URL: {_instaUrl}";
        }

        public string CellPhone
        {
            get { return _cellPhone; }
            set { _cellPhone = value; }
        }
        public string InstaUrl
        {
            get { return _instaUrl; }
            set
            {
                if (!PersonV2._instagramURLRegex.IsMatch(value))
                {
                    Catch.Add("INVALID IG URL");
                    return;
                }
                _instaUrl = value;
            }
        }
    }
}
