namespace _1._Two_Sum;

public class TwoSumProblem {
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numDict = [];
        int i = 0;

        label:
        int complement = target - nums[i];
        if (numDict.TryGetValue(complement, out int idx)) { return [idx, i]; }

        numDict[nums[i]] = i;
        i++;
        goto label;
    }
}
