// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
namespace Program;

class Program
{
    struct Subject
    {
        public string Name;
        public decimal Score;
        public override string ToString()
        {
            return $"subjec name --> {Name} score --> {Score} out of 100.";
        }
    }
    struct Student
    {
        public string Name;
        public int NumberOfSubject;
        public Subject[] Subjects;

        public decimal Average() {
            decimal Total = 0;
            for (int i=0; i < NumberOfSubject; i++) {
                Total += Subjects[i].Score;
            }
            return Total / NumberOfSubject;
        }
        public override string ToString()
        {
            
            string SubjectsString = string.Join('\n', Subjects.Select(subject => subject.ToString()));
            return $"Name ---> {Name} number of subjects ------> {NumberOfSubject}\n{SubjectsString}\n Average ----> {this.Average()}";
        }

    }
    static void Method()
    {
        // Student Object
        Student Student1;

        // Accepting Name
        Console.WriteLine("Your Name: ");
        Student1.Name = Console.ReadLine() ?? "";
        while (Student1.Name.Any(char.IsDigit))
        {
            Console.WriteLine("Your name must be letter only !!!");
            Student1.Name = Console.ReadLine() ?? "";
        }

        // Accepting Number of Subject
        Console.WriteLine("Number of Subject: ");
        string NumberOfSubject = Console.ReadLine() ?? "0";
        while (!int.TryParse(NumberOfSubject, out int score) || int.Parse(NumberOfSubject) < 1)
        {
            Console.WriteLine("Number of subject must be positive number only !!! ");
            NumberOfSubject = Console.ReadLine() ?? "0";
        }
        Student1.NumberOfSubject = int.Parse(NumberOfSubject);


        // Initalizing Array of Subject
        Student1.Subjects = new Subject[Student1.NumberOfSubject];

        //Accepting Input
        for (int i = 0; i < Student1.NumberOfSubject; i++)
        {
            Subject Subject1;

            Console.Write("Subject Name: ");
            Subject1.Name = Console.ReadLine() ?? "";
            while (Subject1.Name.Any(char.IsDigit))
            {
                Console.WriteLine("Subject name must be letter only !!! ");
                Subject1.Name = Console.ReadLine() ?? "";
            }
            Console.WriteLine("Subject Score: ");
            String Score = Console.ReadLine() ?? "0.0";
            while (!decimal.TryParse(Score, out decimal score) || decimal.Parse(Score) < 0 || decimal.Parse(Score) > 100)
            {
                Console.WriteLine("Subject Score must be real number and in between 0 and 100 !!!");
                Score = Console.ReadLine() ?? "0.0";
            }
            Subject1.Score = decimal.Parse(Score);
            Student1.Subjects[i] = Subject1;
        }
        Console.WriteLine(Student1);
        Console.WriteLine(Student1.Average());

    }
}




