using System.Numerics;

namespace _2._Add_Two_Numbers;

public class TwoNumbersV2 : ITwoNumbers
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new(0);
        ListNode? node1 = l1, node2 = l2, current = dummyHead;
        int carry = 0;

        loop_start:

        int a = node1 != null ? node1.val : 0;
        int b = node2 != null ? node2.val : 0;

        if (node1 != null || node2 != null)
        {
            int sum = carry + a + b;
            carry = sum / 10;

            current.next = new ListNode(sum % 10);
            current = current.next;

            node1 = node1?.next;
            node2 = node2?.next;

            goto loop_start;
        }

        if (carry > 0)
        {
            current.next = new ListNode(carry);
        }

        return dummyHead.next ?? new(0);
    }
}