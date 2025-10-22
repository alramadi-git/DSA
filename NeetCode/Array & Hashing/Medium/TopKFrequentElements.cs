namespace ArraysAndHashing.Medium;

public class TopKFrequentElements
{
    public int[] Solution(int[] nums, int k)
    {
        var dictionaryNums = new Dictionary<int /** num */, int /** Count */>();
        foreach (var num in nums) dictionaryNums[num] = dictionaryNums.GetValueOrDefault(num, 0) + 1;

        var topKFrequentElements = new PriorityQueue<int, int>(dictionaryNums.Count);
        foreach (var kvp in dictionaryNums) topKFrequentElements.Enqueue(kvp.Key, -kvp.Value);

        var topKFrequentElementsList = new int[k];
        for (int i = 0; i < k; i++) topKFrequentElementsList[i] = topKFrequentElements.Dequeue();

        return topKFrequentElementsList;
    }
}