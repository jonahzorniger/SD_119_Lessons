using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Conditionals
{
    [TestClass]
    public class SwitchReal
    { 
            enum WeekDay { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
            [TestMethod]
            public void TestMethod1()
            {
                int input = 1;

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;
                    case 2:
                        Console.WriteLine("What are you doing?");
                        break;
                    default:
                        Console.WriteLine("This is default. It will execute if no other cas evaluates as true.");
                        Console.WriteLine("These are not REQUIRED.");
                        break;
                }

                WeekDay today = WeekDay.Sunday;
                switch (today)
                {
                    case WeekDay.Monday:
                        break;
                    case WeekDay.Tuesday:
                        break;
                    case WeekDay.Wednesday:
                        break;
                    case WeekDay.Thursday:
                        break;
                    case WeekDay.Friday:
                        break;
                    case WeekDay.Saturday:
                        break;
                    case WeekDay.Sunday:
                        break;
                    default:
                        break;
                }

                //using switch statements to stack code...
                int age = 37;

                switch (age)
                {
                    case 18:
                        Console.WriteLine("I bet you with you could have a 'legal drink.");
                        break;
                    case 19:
                        Console.WriteLine("Kinda getting closer.");
                        break;
                    case 20:
                        Console.WriteLine("I bet you can taste it.");
                        break;
                    case 21:
                        Console.WriteLine("Finally, Got that 'legal' drink.");
                        break;
                    default:
                        Console.WriteLine("If all else fails....");
                        break;
                }
            }
    }
}
