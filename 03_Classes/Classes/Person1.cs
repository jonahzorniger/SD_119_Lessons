using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Classes
{
    public class Person1
    {
        //Properties of what defines a person
        string personFirstName;
        string personLastName;
        DateTime personBirthDate;


        //Empty initialization
        public Person1() { }

        //Full intialization
        public Person1(string firstName, string lastName, DateTime birthDate) {
        
            personFirstName = firstName;
            personLastName = lastName;
            personBirthDate = birthDate;
        }

        public void setFirstName(string firstName)
        {
            personFirstName = firstName;
        }

        public string getFirstName()
        {
            return personFirstName;
        }

        public void setLastName(string lastName)
        {
            personLastName = lastName;
        }

        public string getLastName()
        {
            return personLastName;
        }

    }
}
