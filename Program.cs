namespace Ovning_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Person person = new Person
                //{
                //    Age = 12,
                //    FName = "Patrick",
                //    Height = 1.32,
                //    LName = "Banica",
                //    Weight = 27.5
                //};
                PersonHandler person = new PersonHandler();
                Person person1 = person.CreatePerson(40, "Dorin", "Chirilov", 1.52, 60);
                Console.WriteLine(person1.ToString());
                Console.WriteLine(person.FullName(person1) + " has BMI = " + person.calculateBMI(person1).ToString().Substring(0, 5));
                person.SetFName(person1, "Gabi");
                person.SetLName(person1, "Singh");
                person.SetAge(person1, 65);
                person.SetHeight(person1, 1.65);
                person.SetWeight(person1, 58.9);
                Person person2 = person.CreatePerson(20, "Florin", "Chiriac", 1.72, 60);
                Person person3 = person.CreatePerson(30, "Marian", "Simion", 1.75, 76);
                Person person4 = person.CreatePerson(50, "Ciprian", "Neculai", 1.82, 83);
                Console.WriteLine(person.FullName(person1) + " has BMI = " + person.calculateBMI(person1).ToString().Substring(0, 5));
                Console.WriteLine(person.FullName(person2) + " has BMI = " + person.calculateBMI(person2).ToString().Substring(0, 5));
                Console.WriteLine(person.FullName(person3) + " has BMI = " + person.calculateBMI(person3).ToString().Substring(0, 5));
                Console.WriteLine(person.FullName(person4) + " has BMI = " + person.calculateBMI(person4).ToString().Substring(0, 5));
                Console.WriteLine(person1.ToString());
                Console.WriteLine(person2.ToString());
                Console.WriteLine(person3.ToString());
                Console.WriteLine(person4.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            List<UserErrors> userErrors = new List<UserErrors>();
            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();
            ThinkingError thinkingError = new ThinkingError();
            SelfishError selfishError = new SelfishError();
            LyingError lyingError = new LyingError();
            userErrors.Add(numericInputError);
            userErrors.Add(textInputError);
            userErrors.Add(thinkingError);
            userErrors.Add(lyingError);
            userErrors.Add(selfishError);
            foreach (var error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }
        List<Animal> animals = new List<Animal>();

        }
    }
}
