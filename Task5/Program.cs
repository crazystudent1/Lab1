using System;

namespace Task5
{
    public class Program
    {
        public static double GetAverage(int[] marks)
        {
            int sum = 0;
            foreach (int mark in marks)
                sum += mark;
            return (double)sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int mark in marks)
                if (mark < min) min = mark;
            return min;
        }

        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int mark in marks)
                if (mark > max) max = mark;
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                double avg = GetAverage(groups[i]);
                int min = GetMin(groups[i]);
                int max = GetMax(groups[i]);

                Console.WriteLine(
                    $"Група {i + 1}: " +
                    $"Середній = {avg:F2}, " +
                    $"Мінімальний = {min}, " +
                    $"Максимальний = {max}");
            }
        }

        public static void Main()
        {
            int[][] groups =
            {
                new int[] { 60, 75, 81, 90, 100 },
                new int[] { 50, 65, 70, 85, 95 },
                new int[] { 90, 92, 98, 100 }
            };

            PrintGroupStatistics(groups);
        }
    }
}