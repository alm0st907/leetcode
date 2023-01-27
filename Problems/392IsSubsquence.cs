namespace Problems;

public class IsSubsequence
{
    public bool IsSubSequence(string s, string t)
    {
        if (s.Length == 0) return true;

        var sIndex = 0;
        foreach (var b in t.Where(b => s[sIndex] == b))
        {
            sIndex++;
            if (sIndex == s.Length) return true;
        }
        
        return false;
    }

}