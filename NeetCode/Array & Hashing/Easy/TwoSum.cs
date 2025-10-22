namespace ArraysAndHashing.Easy;

public class TwoSum
{
    public int[] Solution(int[] nums, int target)
    {
        Dictionary<int, int> dictionaryNums = new Dictionary<int, int>() { };

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];

            if (dictionaryNums.TryGetValue(target - num, out int valueIndex)) return new int[] { Math.Min(i, valueIndex), Math.Max(i, valueIndex) };
            else dictionaryNums.Add(num, i);
        }

        return new int[] { };
    }
};