using System;
using System.Collections.Generic;



namespace aoc2024_CS_2
{
    public static class Shared
    {
        public static List<List<UInt16>> s_list;
    } // !class Shared



    internal class Program
    {
        static void Main(string[] args)
        {
            aoc2024_CS_2_a.Solution(args);

            aoc2024_CS_2_b.Solution();
        }
    } // !class Program



} // !namespace aoc2024_CS_2
