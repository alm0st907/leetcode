namespace Problems;

public class IsomorphicStrings
{
    public bool IsIsomorphic(string s, string t)
    {
        //can letter of s be replaced to equal t
        // eg - does the pattern match like a bitflip 011 could be flipped to 100 so they're true        var dict = new Dictionary<char, char>();
        var dict = new Dictionary<char, char>();
        for(int i = 0 ; i < s.Length; i++)
        {
            char ss = s[i];
            char st = t[i];
            if(dict.ContainsKey(ss))
            {
                //if we contain the key, make sure we're pattern matching
                if(st != dict[ss]) return false;
            } 
            else 
            {
                //second hand pattern check
                if(dict.ContainsValue(st)) return false;
                dict.Add(ss, st);
            }
        }
        return true;
    }

}