using System.Numerics;
using _2._Add_Two_Numbers;

Console.WriteLine("Problem: Add Two Numbers");

//Input
var l1 = new ListNode(9);
var l2 = new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))))));

//Run
var watch = new System.Diagnostics.Stopwatch();
watch.Start();
var result = new TwoNumbers().AddTwoNumbers(l1, l2);
watch.Stop();

//Show results
Console.WriteLine($"Result: {result}");
Console.WriteLine($"Execution Time: {watch.Elapsed.Microseconds / 1000.00} ms");
