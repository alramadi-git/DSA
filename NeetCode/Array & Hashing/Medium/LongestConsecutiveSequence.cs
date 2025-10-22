namespace ArraysAndHashing.Medium;

public class LongestConsecutiveSequence
{
    public int Solution(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var set = new HashSet<int>(nums);
        var longestConsecutiveSequence = 0;

        foreach (var num in nums)
        {
            var lowest = num - 1;
            var greatest = num + 1;

            while (set.Contains(lowest)) lowest -= 1;
            while (set.Contains(greatest)) greatest += 1;

            lowest += 1;
            greatest -= 1;
            longestConsecutiveSequence = Math.Max(greatest - lowest, longestConsecutiveSequence);
        }

        return longestConsecutiveSequence + 1;
    }
}