namespace ArraysAndHashing.Easy;

public class ContainsDuplicate
{
    public bool Solution(int[] nums)
    {
        HashSet<int> hashSetNums = new();

        foreach (int num in nums)
            if (!hashSetNums.Add(num)) return true;

        return false;
    }
};