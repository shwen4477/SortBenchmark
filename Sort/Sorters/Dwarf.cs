namespace Sort.Sorters
{
	/// <summary>
	/// Гномья
	/// </summary>
	public class Dwarf : BaseSorter
	{
		public override int[] Sort(int[] arr)
		{
			var i = 1;
			var rightBound = 0;
			while (i < arr.Length)
			{
				if (arr[i] >= arr[i - 1])
				{
					if (rightBound > i)
					{
						i = rightBound;
					}
					i++;
				}
				else
				{
					if (i > rightBound)
					{
						rightBound = i;
					}
					this.Swap(ref arr[i], ref arr[i-1]);
					if (i > 1)
					{
						i--;
					}
				}
			}
			return arr;
		}
	}
}