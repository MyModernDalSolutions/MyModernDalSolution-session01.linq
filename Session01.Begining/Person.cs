using System;

namespace Session01.Begining
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName
        {
            get
            {
                //Console.WriteLine($"Reading {_lastName}");
                return _lastName;
            }
            set => _lastName = value;
        }
    }
}
