using System;
using System.IO;
class Result
{
    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */
    public static int pageCount(int n, int p)
    {
        int fromFront = p / 2;
        int fromBack = n / 2 - p / 2;
        return Math.Min(fromFront, fromBack);
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
        string pInput = Console.ReadLine();
        if (pInput == null) return;
        int p = Convert.ToInt32(pInput.Trim());
        int result = Result.pageCount(n, p);
        textWriter.WriteLine(result);
        textWriter.Flush();
        if (!string.IsNullOrEmpty(outputPath))
        {
            textWriter.Close();
        }
    }
}

