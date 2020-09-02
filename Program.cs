namespace StudentsAndInstructors
{
    class Program
    {
        static void Main(string[] args)
        { 
            Student bob = new Student();
            bob.Name = "Bob";
            bob.Cohort = 99;
            bob.IsThirsty = true;
            bob.FavoriteLanguage = "C#";
            //bob.Greet();
            //bob.Learn("Inheritance");
            //bob.AskQuestion();

            Instructor mary = new Instructor();
            mary.Name = "Mary";
            mary.Cohort = 99;
            mary.Specialty = "LINQ";
            mary.MonthsOfExperience = 1200;
            //mary.Greet();
            //mary.Teach("variables");

            SayHello(bob);
            SayHello(mary);
        }

        static void SayHello(Person aPerson)
        {
            aPerson.Greet();
        }
    }
}