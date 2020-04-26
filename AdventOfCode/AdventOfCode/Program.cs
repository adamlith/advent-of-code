using System;

namespace AdventOfCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var year = ReadConsoleInput("year");
                var day = ReadConsoleInput("day");

                var problem = ProblemBase.AllProblems[(year, day)];
                var input = InputLoader.LoadInput(problem);

                var result = problem.Solve(input);

                Console.WriteLine($"Result: {result}");
            }
        }

        private static int ReadConsoleInput(string name)
        {
            int result;
            do
            {
                Console.WriteLine($"Select problem {name}:");
            } while (!int.TryParse(Console.ReadLine(), out result));

            return result;
        }
    }
}
