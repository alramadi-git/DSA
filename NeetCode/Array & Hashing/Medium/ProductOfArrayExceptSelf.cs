namespace ArraysAndHashing.Medium;

public class ProductOfArrayExceptSelf
{
    public int[] Solution(int[] nums)
    {
        var leftToRight = new int[nums.Length];
        var rightToLeft = new int[nums.Length];
        var result = new int[nums.Length];

        leftToRight[0] = nums[0];
        for (var i = 1; i < nums.Length; i++) leftToRight[i] = leftToRight[i - 1] * nums[i];

        rightToLeft[^1] = nums[^1];
        for (var i = nums.Length - 2; i > -1; i--) rightToLeft[i] = rightToLeft[i + 1] * nums[i];

        result[0] = rightToLeft[1];
        result[^1] = leftToRight[^2];
        for (var i = 1; i < nums.Length - 1; i++) result[i] = leftToRight[i - 1] * rightToLeft[i + 1];

        return result;
    }
};