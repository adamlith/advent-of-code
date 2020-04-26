using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public abstract class ProblemBase<TResult, TInput> : ProblemBase
    {
        public abstract TResult Solve(IEnumerable<TInput> inputs);

        public override string Solve(IEnumerable<string> input)
        {
            return Solve(input.Select(i => (TInput)Convert.ChangeType(i, typeof(TInput)))).ToString();
        }
    }

    public abstract class ProblemBase
    {
        public static IDictionary<(int Year, int Day), ProblemBase> AllProblems;

        static ProblemBase()
        {
            var baseType = typeof(ProblemBase);
            AllProblems = baseType.Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(baseType))
                .Where(t => !t.IsAbstract)
                .Select(t => t.GetConstructors().Single().Invoke(Array.Empty<object>()))
                .Cast<ProblemBase>()
                .ToDictionary(p => (p.Year, p.Day));
        }

        public abstract int Year { get; }
        public abstract int Day { get; }

        public abstract string Solve(IEnumerable<string> input);
    }
}