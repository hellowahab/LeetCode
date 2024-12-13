using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.inserting_items_into_an_array.Duplicate_Zeros
{
	internal class DuplicateZeros
	{
		/// <summary>
		/// Given a fixed length array arr of integers, duplicate each occurrence of zero, shifting the remaining elements to the right.
		/// This is the first solution I have tried an come up with.
		/// </summary>
		/// <param name="arr"></param>
		public void FirstSolution(int[] arr)
		{
			for (int i = 0; i < arr.Length - 1; i++)
			{
				if (arr[i] == 0)
				{
					for (int j = arr.Length - 1; j > i; j--)
						arr[j] = arr[j - 1];
					arr[i + 1] = 0;
					i++;
				}
			}

			Console.WriteLine(string.Join(", ", arr));
		}
	}
}
