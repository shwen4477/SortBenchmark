using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Sort.Sorters
{
	/// <summary>
	/// Слияние
	/// </summary>
	public class Merge : BaseSorter
	{
		public override int[] Sort(int[] arr)
		{
			if (arr.Length == 1)
			{
				return arr;
			}

			var midPoint = arr.Length / 2;
			int[] arr1 = arr.Take(midPoint).ToArray();
			int[] arr2 = arr.Skip(midPoint).ToArray();
			return MergeTwoSortedArrays(Sort(arr1), Sort(arr2));
		}

		private int[] MergeTwoSortedArrays(int[] arr1, int[] arr2)
		{
			var resArray = new int[arr1.Length + arr2.Length];
			int i = 0;
			int j = 0;
			for (int k = 0; k < arr1.Length + arr2.Length; k++)
			{
				if (i < arr1.Length && j < arr2.Length)
				{
					if (arr1[i] <= arr2[j])
					{
						resArray[k] = arr1[i];
						i++;
					}
					else
					{
						resArray[k] = arr2[j];
						j++;
					}
				}
				else
				{
					if (i < arr1.Length)
					{
						resArray[k] = arr1[i];
						i++;
					}
					if (j < arr2.Length)
					{
						resArray[k] = arr2[j];
						j++;
					}
				}
			}
			return resArray;
		}
	}
}