namespace Sort.Sorters
{
	/// <summary>
	/// Базовая сортировка
	/// </summary>
	public abstract class BaseSorter : ISorter
	{
		public int OperationCount;

		public virtual int[] Sort(int[] arr)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Перестановка двух чисел
		/// </summary>
		/// <param name="val1">Первая переменная</param>
		/// <param name="val2">Вторая переменная</param>
		protected void Swap(ref int val1, ref int val2)
		{
			val1 = val1 + val2;
			val2 = val1 - val2;
			val1 = val1 - val2;
		}
	}
}