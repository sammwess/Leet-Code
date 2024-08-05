using NuGet.Frameworks;

namespace _1._Two_Sum.Tests;

public class TwoSumTest
{
    [Fact]
    public void Add_271115_target_9_Expects01()
    {
        int[] result = TwoSumProblem.TwoSum([2, 7, 11, 15], 9);

        Assert.Equal([0,1], result);
    }

    [Fact]
    public void Add_324_target_6_Expects12()
    {
        int[] result = TwoSumProblem.TwoSum([3, 2, 4], 6);

        Assert.Equal([1,2], result);
    }

    [Fact]
    public void Add_33_target_6_Expects01()
    {
        int[] result = TwoSumProblem.TwoSum([3, 3], 6);

        Assert.Equal([0,1], result);
    }
}