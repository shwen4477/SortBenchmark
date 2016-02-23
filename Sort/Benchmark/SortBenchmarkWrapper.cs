using System;
using System.Linq;

using BenchmarkDotNet.Attributes;

using Sort.Sorters;

namespace Sort.Benchmark
{
	/// <summary>
	/// Замерялка
	/// </summary>
	[Config(typeof(BenchmarkConfig))]
	public class SortBenchmarkWrapper//<T> where T : BaseSorter, new()
	{
		private static byte[] _arr = GenerateArray();

		[Benchmark(Description = "Buble 3 optimisation")]
		public void TestBuble()
		{
			var sorter = new Buble();
			sorter.Sort(GetWorkCopyOfArray());
		}

		[Benchmark(Description = "Selection")]
		public void TestSelection()
		{
			var sorter = new Selection();
			sorter.Sort(GetWorkCopyOfArray());
		}

		[Benchmark(Description = "Insertion")]
		public void TestInsertion()
		{
			var sorter = new Insertion();
			sorter.Sort(GetWorkCopyOfArray());
		}

		[Benchmark(Description = "Dwarf")]
		public void TestDwarf()
		{
			var sorter = new Dwarf();
			sorter.Sort(GetWorkCopyOfArray());
		}

		[Benchmark(Description = "Merge")]
		public void TestMerge()
		{
			var sorter = new Merge();
			sorter.Sort(GetWorkCopyOfArray());
		}

		public static int[] GetWorkCopyOfArray()
		{
			return _arr.Select(a => (int)a).ToArray();
		}

		private static byte[] GenerateArray()
		{
			var buffer = new byte[1000];
			var rand = new Random();
			rand.NextBytes(buffer);
			return buffer;
			//return new byte[] { 2, 3, 4, 1 };
		}
	}
}