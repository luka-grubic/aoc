using System;
using System.Collections.Generic;
using System.IO;



namespace aoc2024_1
{
    public static class aoc2024_1_a
    {
        public static void Solution(string[] args)
        {
            string inFilePath = args[0];

            List<UInt32> left = new List<UInt32>();
            List<UInt32> right = new List<UInt32>();
            UInt32 sum = 0;

            foreach (string line in File.ReadAllLines(inFilePath))
            {
                string formattedLine = line.Replace("   ", "-");
                left.Add(Convert.ToUInt32(formattedLine.Split('-')[0]));
                right.Add(Convert.ToUInt32(formattedLine.Split('-')[1]));
            }

            left.Sort();
            right.Sort();

            Shared.s_left = left;
            Shared.s_right = right;

            for (int i = 0; i < left.Count; i++)
            {
                sum += (Math.Max(left[i], right[i]) - Math.Min(left[i], right[i]));
            }

            Console.WriteLine($"SOLUTION aoc2024-1-a: {sum}");
        }
    }
}
