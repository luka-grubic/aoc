using System;
using System.Collections.Generic;
using System.Linq;



namespace aoc2024_1
{



    public static class aoc2024_1_b
    {



        public static void Solution()
        {
            List<UInt32> left = Shared.s_left;
            List<UInt32> right = Shared.s_right;
            UInt32 sum = 0;

            var group = right.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());

            foreach (UInt32 value in left)
            {
                if (group.ContainsKey(value))
                {
                    sum += (UInt32)(value * group[value]);
                }
            }

            Console.WriteLine($"SOLUTION aoc2024-1-b: {sum}");
        }



    } // !class aoc2024_1_b



} // !namespace aoc2024_1
