using System;
using System.Collections.Generic;



namespace aoc2024_CS_1
{



    public static class Shared
    {
        public static List<UInt32> s_left, s_right;
    } // !class Shared



    internal class Program
    {
        static void Main(string[] args)
        {
            aoc2024_CS_1_a.Solution(args);

            aoc2024_CS_1_b.Solution();
        }
    } // !class Program



} // !namespace aoc2024_CS_1
