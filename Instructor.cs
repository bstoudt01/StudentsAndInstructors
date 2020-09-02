using System;

namespace StudentsAndInstructors
{
    public class Instructor : Person
    {
        public string Specialty { get; set; }
        public int MonthsOfExperience { get; set; }

        public void Teach(string lesson)
        {
            Console.WriteLine($"{Name} teaches {lesson}");
        }

        public override void Greet()
        {
            Console.WriteLine($"My name is {Name} and I'll be teaching you.");
        }
    }
}