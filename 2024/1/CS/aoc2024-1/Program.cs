using System;
using System.Collections.Generic;



namespace aoc2024_1
{
    public static class Shared
    {
        public static List<UInt32> s_left, s_right;
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            aoc2024_1_a.Solution(args);

            aoc2024_1_b.Solution();
        }
    }
}
