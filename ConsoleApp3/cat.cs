using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   
   
        public class Cat
        {
            public Cat(string name, DateTime berthday)
            {
                Name = name;
                BerthDay = berthday;
            }

            public string Name
            {
                get;
                set;
            }
            public void MakeNoise()
            {

                Console.WriteLine($"{Name} мяукает");
            }
            public DateTime BerthDay
            {
                get;
                set;
            }
            public int GetAge()
            {
                return (DateTime.Today - BerthDay).Days / 365;

            }
        }
    }


