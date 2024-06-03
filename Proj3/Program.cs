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
