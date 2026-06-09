class Result
{
    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static int migratoryBirds(System.Collections.Generic.List<int> arr)
    {
        int[] counts = new int[6];
        
        foreach (int type in arr)
        {
            counts[type]++;
        }

        int maxCount = 0;
        int maxId = 0;

        for (int i = 1; i <= 5; i++)
        {
            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                maxId = i;
            }
        }
        return maxId;
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        System.IO.TextWriter textWriter = new System.IO.StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string nInput = System.Console.ReadLine();
        if (nInput != null)
        {
            int arrCount = System.Convert.ToInt32(nInput.Trim());
        }
        System.Collections.Generic.List<int> arr = new System.Collections.Generic.List<int>();
        string arrLine = System.Console.ReadLine();
    
        if (arrLine != null)
        {
            string[] arrTokens = arrLine.TrimEnd().Split(' ');
            foreach (string s in arrTokens)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    arr.Add(System.Convert.ToInt32(s));
                }
            }
        }
        int result = Result.migratoryBirds(arr);
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
