using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Concepts
{
    class Person
    {
        public string firstName;
        public string lastName;
        public string salutation;
        private string salutationMr = "Mr.";
        private string salutationMrs = "Mrs.";
        private string defaultlastName = "NMN";
        public string getName()
        {
            return salutation+ " "+firstName + " " + lastName;
        }
    }
}
