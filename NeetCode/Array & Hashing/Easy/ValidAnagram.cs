namespace ArraysAndHashing.Easy;

public class ValidAnagram
{
    public bool Solution(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> dictionaryS = new Dictionary<char, int>();

        foreach (char character in s)
            dictionaryS[character] = 1 + dictionaryS.GetValueOrDefault(character, 0);

        foreach (char character in t)
        {
            if (!dictionaryS.TryGetValue(character, out int count) || count == 0) return false;
            dictionaryS[character]--;
        }

        return true;
    }
};