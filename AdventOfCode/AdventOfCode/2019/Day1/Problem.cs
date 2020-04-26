using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode._2019.Day1
{
    public class Problem : ProblemBase<int, int>
    {
        public override int Solve(IEnumerable<int> inputs)
        {
            return inputs.Sum(i => i / 3 - 2);
        }

        public override int Year => 2019;
        public override int Day => 1;
    }
}