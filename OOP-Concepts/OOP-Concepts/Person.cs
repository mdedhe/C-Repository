using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Concepts
{
    class Person
    {
        public string firstName;
        public string lastName;
        private string salutation = "Mr.";
        public string getName()
        {
            return salutation+ " "+firstName + " " + lastName;
        }
    }
}
