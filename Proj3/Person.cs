using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private int height;
        private int weight;

        public int Age { get => age; set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                else { age = value; }
            } 
        }
        public string FName { get => fName; set 
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new Exception("First name must be between 2 and 10 characters");
                }
                else { fName = value; }
            }
        }
        public string LName { get => lName; set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new Exception("Last name must be between 3 and 15 characters");
                } else { lName = value; }
            }
        }
        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }


    }
}
