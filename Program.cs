using LeetCode.inserting_items_into_an_array.Duplicate_Zeros;
using System.Diagnostics;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duplicate Zeros!");
			var duplicateZeros = new DuplicateZeros();
            int[] arr = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			duplicateZeros.FirstSolution(arr);
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            Console.WriteLine($"Execution Time: {timeSpan.Minutes}m {timeSpan.Seconds}s {timeSpan.Milliseconds}ms {timeSpan.Nanoseconds}ns");
			Console.ReadLine();
		}
    }
}
