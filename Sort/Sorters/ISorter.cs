namespace Sort.Sorters
{
	public interface ISorter
	{
		/// <summary>
		/// Сортируем
		/// </summary>
		/// <param name="arr">Входной массив</param>
		/// <returns>Отсортирванный массив</returns>
		int[] Sort(int[] arr);
	}
}