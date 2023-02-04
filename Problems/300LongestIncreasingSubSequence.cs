namespace Problems;

public static class HNHackerRank
{
    /// <summary>
    /// n^2 solution
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int findLISasDP(int[] s)
    {
        //count of the current longest subsequence, stored in list
        var answers = new int[s.Length];
        //iterate backwards through the list
        for (var i = s.Length - 1; i >=0 ; i--)
        {
            //default length is always 1
            answers[i] = 1;
            //iterate back to the end and compare, store answer if we can make a subsequence
            for (var j = i + 1; j < s.Length; j++)
            {
                if (s[i] < s[j] && answers[i] < 1 + answers[j])
                {
                    //increment and store the answer based on position
                    answers[i] = 1 + answers[j];
                }
            }
        }
        //take the max of our list for answer
        return answers.Max();
    }

    /// <summary>
    /// nlogn solution with binary search
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int findLISwithBS(int[] nums)
    {
        List<LinkedList<int>> tree = new List<LinkedList<int>>();
        foreach (var x in nums)
        {
            int left = 0;
            int right = tree.Count - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (tree[mid].Last.Value < x)
                    left = mid + 1;
                else right = mid - 1;
            }
            if (left >= tree.Count) tree.Add(new LinkedList<int>(new[] {x}));
            else tree[left].AddLast(x);
        }

        //levels to the tree give us the longest sub
        return tree.Count;
    }
}