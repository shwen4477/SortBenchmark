namespace Sort.Sorters
{
	/// <summary>
	/// Сортировка вставками
	/// </summary>
	public class Insertion : BaseSorter
	{
		public override int[] Sort(int[] arr)
		{
			for (int i = 1; i < arr.Length; i++)
			{
				int j = i;
				while (j > 0 && arr[j] < arr[j-1])
				{
					this.Swap(ref arr[j], ref arr[j-1]);
					j --;
				}
			}
			return arr;
		}
	}
}