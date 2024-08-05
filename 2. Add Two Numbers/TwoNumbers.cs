using System.Numerics;

namespace _2._Add_Two_Numbers;

public class TwoNumbers : ITwoNumbers
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode? node = l1;
        string iNumL1 = "";
        do
        {
            iNumL1 += node.val;
            node = node.next;
        } while (node != null);

        node = l2;
        string iNumL2 = "";
        do
        {
            iNumL2 += node.val;
            node = node.next;
        } while (node != null);

        var num3 = (GetNumber(iNumL1) + GetNumber(iNumL2)).ToString();
        int s = num3.Length;

        ListNode? head = null;

        for (int i = 0; i < s; i++)
        {
            var newHead = new ListNode(int.Parse(num3[i].ToString()), head);
            head = newHead;
        }

        return head ?? new ListNode(0);
    }

    public static BigInteger GetNumber(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return BigInteger.Parse(new string(charArray));
    }
}