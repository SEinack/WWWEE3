using System;
using System.Collections.Generic;
using System.IO;
class Result
{
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
    public static int diagonalDifference(List<List<int>> arr)
    {
        int leftDiagonal = 0;
        int rightDiagonal = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            leftDiagonal += arr[i][i];
            rightDiagonal += arr[i][arr.Count - 1 - i];
        }

        return Math.Abs(leftDiagonal - rightDiagonal);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Smart output selection: to file for HackerRank, to console for local testing
        string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");
        TextWriter textWriter;
        
        if (!string.IsNullOrEmpty(outputPath))
        {
            textWriter = new StreamWriter(outputPath, true);
        }
        else
        {
            textWriter = Console.Out;
        }

        string nInput = Console.ReadLine();
        if (nInput == null) return;
        int n = Convert.ToInt32(nInput.Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            List<int> row = new List<int>();
            if (line != null)
            {
                string[] tokens = line.TrimEnd().Split(' ');
                foreach (string s in tokens)
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        row.Add(Convert.ToInt32(s));
                    }
                }
            }
            arr.Add(row);
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        
        if (!string.IsNullOrEmpty(outputPath))
        {
            textWriter.Close();
        }
    }
}
.cs
