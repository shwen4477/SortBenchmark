namespace Sort.Sorters
{
	/// <summary>
	/// Выбор
	/// </summary>
	public class Selection : BaseSorter
	{
		///<inheritdoc/>
		public override int[] Sort(int[] arr)
		{
			int[] arr1 = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				var min = i;
				for (int j = i; j < arr.Length; j++)
				{
					this.OperationCount++;
					if (arr[j] < arr[min])
					{
						min = j;
					}
				}
				this.OperationCount++;
				if (min != i)
				{
					//arr1[i] = arr[min];
					this.Swap(ref arr[i], ref arr[min]);
				}
			}
			//return arr1;
			return arr;
		}
	}
}