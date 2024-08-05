
using System.Diagnostics;

namespace _2._Add_Two_Numbers;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static implicit operator ListNode(TwoNumbers v)
    {
        throw new NotImplementedException();
    }

    override public string ToString() {
        ListNode? node = this;
        string iNum = "";
        do
        {
            iNum += node.val;
            node = node.next;
        } while (node != null);

        char[] charArray = iNum.ToCharArray();
        Array.Reverse(charArray);

        return new string(charArray);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

