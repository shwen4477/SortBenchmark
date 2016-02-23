namespace Sort.Sorters
{
	public class Buble : BaseSorter
	{
		public override int[] Sort(int[] arr)
		{
			bool wasChange = true;
			var len = arr.Length;
			while (wasChange)
			{
				wasChange = false;
				for (int j = 1; j < len; j++)
				{
					this.OperationCount++;
					if (arr[j] < arr[j - 1])
					{
						this.Swap(ref arr[j], ref arr[j - 1]);
						wasChange = true;
					}
				}
				if (wasChange)
				{
					for (int j = len - 2; j > arr.Length - len; j--)
					{
						this.OperationCount++;
						if (arr[j] < arr[j - 1])
						{
							this.Swap(ref arr[j], ref arr[j - 1]);
							wasChange = true;
						}
					}
					len--;
				}
			}
			return arr;
		}
	}
}