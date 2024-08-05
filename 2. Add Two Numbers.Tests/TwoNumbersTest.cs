using NuGet.Frameworks;

namespace _2._Add_Two_Numbers.Tests;

public class TwoNumbersTest
{
    [Fact]
    public void Add_246_and_564_Returns807()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        ITwoNumbers twoNumbers = new TwoNumbers();
        var result = twoNumbers.AddTwoNumbers(l1, l2);

        Assert.Equal("807", result.ToString());
    }

    [Fact]
    public void Add_0_and_0_Returns0()
    {
        var l1 = new ListNode(0);
        var l2 = new ListNode(0);

        ITwoNumbers twoNumbers = new TwoNumbers();
        var result = twoNumbers.AddTwoNumbers(l1, l2);

        Assert.Equal("0", result.ToString());
    }

    [Fact]
    public void Add_9999999_and_9999_Returns10009998()
    {
        var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

        ITwoNumbers twoNumbers = new TwoNumbers();
        var result = twoNumbers.AddTwoNumbers(l1, l2);

        Assert.Equal("10009998", result.ToString());
    }

    [Fact]
    public void Add_9_and_1999999999_Returns10000000000()
    {
        var l1 = new ListNode(9);
        var l2 = new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))))));

        ITwoNumbers twoNumbers = new TwoNumbers();
        var result = twoNumbers.AddTwoNumbers(l1, l2);

        Assert.Equal("10000000000", result.ToString());
    }
}