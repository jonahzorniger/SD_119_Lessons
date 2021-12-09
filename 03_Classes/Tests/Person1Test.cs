using _03_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Classes.Tests
{
    [TestClass]
    public class Person1Test
    {
        [TestMethod]
        public void TestPersonName()
        {
            //Jonah does not have any properties initialized
            Person1 jonah = new Person1();

            // Nicole has properties initialized
            Person1 nicole = new Person1("Nicole", "Kitson", new DateTime(1992,8,1));



            Console.WriteLine(jonah.getFirstName());

            Console.WriteLine(nicole.getFirstName());



            jonah.setFirstName("Jonah");

            Console.WriteLine(jonah.getFirstName());



            //Display Jonahs Last Name

            jonah.setLastName("Zorniger");

            Console.WriteLine(jonah.getLastName());


        }
    }
}
