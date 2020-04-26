using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AdventOfCode
{
    public class InputLoader
    {
        public static IEnumerable<string> LoadInput(ProblemBase problem)
        {
            var assembly = Assembly.GetExecutingAssembly();

            using var stream = assembly.GetManifestResourceStream(problem.GetType().Namespace + ".Input.txt");
            using var reader = new StreamReader(stream);

            return reader.ReadToEnd().Split(Environment.NewLine);
        }
    }
}