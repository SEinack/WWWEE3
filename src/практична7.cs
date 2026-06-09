class Result
{
    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */
    public static System.Collections.Generic.List<int> breakingRecords(System.Collections.Generic.List<int> scores)
    {
        if (scores == null || scores.Count == 0) 
        {
            System.Collections.Generic.List<int> emptyResult = new System.Collections.Generic.List<int>();
            emptyResult.Add(0);
            emptyResult.Add(0);
            return emptyResult;
        }

        int maxScore = scores[0];
        int minScore = scores[0];

        int maxBreaks = 0;
        int minBreaks = 0;

        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > maxScore)
            {
                maxScore = scores[i];
                maxBreaks++;
            }
            else if (scores[i] < minScore)
            {
                minScore = scores[i];
                minBreaks++;
            }
        }

        System.Collections.Generic.List<int> result = new System.Collections.Generic.List<int>();
        result.Add(maxBreaks);
        result.Add(minBreaks);
        return result;
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
            int n = System.Convert.ToInt32(nInput.Trim());
        }

        System.Collections.Generic.List<int> scores = new System.Collections.Generic.List<int>();
        string scoresLine = System.Console.ReadLine();
        
        if (scoresLine != null)
        {
            string[] scoresTokens = scoresLine.TrimEnd().Split(' ');
            foreach (string s in scoresTokens)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    scores.Add(System.Convert.ToInt32(s));
                }
            }
        }

        System.Collections.Generic.List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(result[0] + " " + result[1]);

        textWriter.Flush();
        textWriter.Close();
    }
}
