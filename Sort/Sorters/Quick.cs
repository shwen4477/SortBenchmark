using System;

namespace Sort.Sorters
{
	/// <summary>
	/// Быстрая сортировка
	/// </summary>
	public class Quick : BaseSorter
	{
		public override int[] Sort(int[] arr)
		{
			return Sort(arr, 0, arr.Length - 1) ;
		}

		/// <summary>
		/// Получение элемента, по которому будем бить массив на две части
		/// </summary>
		/// <param name="arr"></param>
		/// <returns>Элемент, по которому будем бить массив на две части</returns>
		private int GetDevideItem(int[] arr, int left, int right)
		{
			Random rnd = new Random(arr.Length);
			var ind = rnd.Next(left, right);
			return arr[ind];
		}

		private int[] Sort(int[] arr, int left, int right)
		{
			var devider = GetDevideItem(arr, left, right);
			int i = left;
			int j = right;
			while (i <= j)
			{
				while (arr[i] < devider)
				{
					i++;
				}
				while (arr[j] > devider)
				{
					j--;
				}
				if (i <= j)
				{
					if (i != j)
					{
						Swap(ref arr[i], ref arr[j]);
					}
					i++;
					j--;
				}
			}

			if (i < right)
			{
				return Sort(arr, i, right);
			}

			if (j > left)
			{
				return Sort(arr, left, j);
			}
			return arr;
		}
	}
}