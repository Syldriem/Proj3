using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    internal class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            try
            {
                person.Age = age;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public Person CreatePerson(int age, string fName, string lName, int height, int weight)
        {
            Person person = new Person();
            try
            {
                person.Age = age;
                person.FName = fName;
                person.LName = lName;
                person.Height = height;
                person.Weight = weight;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            return person;
        }

        public void SetFName(Person person, string fName)
        {
            try
            {
                person.FName = fName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SetLName(Person person, string lName)
        {
            try
            {
                person.LName = lName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SetHeight(Person person, int height)
        {
            person.Height = height;
        }

        public void SetWeight(Person person, int weight)
        {
            person.Weight = weight;
        }

        public void PrintPerson(Person person)
        {
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"First name: {person.FName}");
            Console.WriteLine($"Last name: {person.LName}");
            Console.WriteLine($"Height: {person.Height}");
            Console.WriteLine($"Weight: {person.Weight}");
        }
    }
}
