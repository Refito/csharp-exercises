using System;

namespace Getting_Ready_For_Examination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allowedBadGrades = int.Parse(Console.ReadLine());
            int badGrades = 0, sumGrades = 0, problems = 0;

            string input = Console.ReadLine(), question = "";

            while (input != "Enough")
            {
                problems++;

                question = input;
                var grade = int.Parse(Console.ReadLine());
                if (grade <= 4) badGrades++;
                sumGrades += grade;

                if (allowedBadGrades == badGrades)
                {
                    Console.WriteLine($"You need a break, {badGrades} poor grades.");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Average score: {(double)sumGrades / problems}");
            Console.WriteLine($"Number of problems: {problems}");
            Console.WriteLine($"Last problem: {question}");
        }
    }
}
