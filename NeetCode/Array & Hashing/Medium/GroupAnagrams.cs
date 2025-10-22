namespace ArraysAndHashing.Medium;

public class GroupAnagrams
{
    public List<List<string>> Solution(string[] strs)
    {
        var dictionaryStrs = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var anagram = new int[26];

            foreach (var chr in str) anagram[(int)chr - (int)'a'] += 1;

            var key = string.Join(",", anagram);

            if (!dictionaryStrs.TryGetValue(key, out var list))
            {
                list = new(1);
                dictionaryStrs.Add(key, list);
            }

            list.Add(str);
        }

        return dictionaryStrs.Values.ToList();
    }
};