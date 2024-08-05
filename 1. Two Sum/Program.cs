using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using _1._Two_Sum;

Console.WriteLine("Problem: Two Sum");

var watch = new System.Diagnostics.Stopwatch();
watch.Start();
int[] result = TwoSumProblem.TwoSum([3, 2, 4], 6);
watch.Stop();

Console.WriteLine($"Result: {string.Join(",", result)}");
Console.WriteLine($"Execution Time: {watch.Elapsed.Microseconds / 1000.00} ms");
