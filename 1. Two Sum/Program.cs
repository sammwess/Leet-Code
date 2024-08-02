using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace _1._Two_Sum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Two Sum");

        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        int[] result = TwoSum([3, 2, 4], 6);
        watch.Stop();

        Console.WriteLine($"Result: {string.Join(",", result)}");
        Console.WriteLine($"Execution Time: {watch.Elapsed.Microseconds / 1000.00} ms");
    }

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
