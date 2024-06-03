namespace Proj3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            PersonHandler personHandler = new PersonHandler();
            Person John = personHandler.CreatePerson(20, "John", "Doe", 180, 80);
            personHandler.SetFName(John, "Mary");
            personHandler.PrintPerson(John);

            List<UserError> errors = new List<UserError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new ShortLengthInputError());
            errors.Add(new LongLengthInputError());
            errors.Add(new DumbInputError());
            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("bob", 5, 5.1, "white"));
            animals.Add(new Pelican("pelle", 3, 3.5, 1.5, 15));
            animals.Add(new Wolfman("wolfie", 10, 100, 5));
            List<Dog> dogs = new List<Dog>();
            // 9. Kan inte konvertera från Horse till Dog eftersom Horse inte ärver från Dog
            // 10. Animal klassen

            foreach (Animal animal in animals)
            {
                if (animal is IPerson)
                {
                    IPerson person = (IPerson)animal;
                    person.Talk();
                }
                Console.WriteLine(animal.GetType());
                animal.DoSound();
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
                if (animal is Dog)
                {
                    Dog dog = (Dog)animal;
                    dog.Barkbark();
                }
            }
            // 13. De olika klasser ärver name och age osv props från Animal klassen

            foreach (Dog dog in animals)
            { 
                if (dog is Dog)
                {
                    Console.WriteLine(dog.Stats());
                }
            }

            // 17. Alla animals har inte den metoden, så det går inte att anropa den på alla

            try
            {
                John.Age = -1;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
