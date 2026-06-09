using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Result
{
    public static int getTotalX(List<int> a, List<int> b)
    {
        int count = 0;
        for (int x = a.Max(); x <= b.Min(); x++)
        {
            bool valid = true;
            foreach (int num in a)
            {
                if (x % num != 0)
                {
                    valid = false;
                    break;
                }
            }
            if (valid)
            {
                foreach (int num in b)
                {
                    if (num % x != 0)
                    {
                        valid = false;
                        break;
                    }
                }
            }

            if (valid)
                count++;
        }
        return count;
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter writer;

        string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");

        if (!string.IsNullOrEmpty(outputPath))
        {
            writer = new StreamWriter(outputPath, true);
        }
        else
        {
            writer = Console.Out;
        }
        string[] firstMultipleInput = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(firstMultipleInput[0]);
        int m = int.Parse(firstMultipleInput[1]);
        List<int> a = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
        List<int> b = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
        int result = Result.getTotalX(a, b);
        writer.WriteLine(result);
        writer.Flush();

        if (writer != Console.Out)
            writer.Close();
    }
}
