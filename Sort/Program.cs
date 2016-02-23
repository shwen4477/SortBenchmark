using System;

using BenchmarkDotNet.Running;

using Sort.Benchmark;
using Sort.Sorters;

namespace Sort
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseSorter s = new Buble();
			var res = s.Sort(SortBenchmarkWrapper.GetWorkCopyOfArray());
			Console.WriteLine(string.Join(",", res));
			Console.WriteLine(s.OperationCount);

			s = new Selection();
			res = s.Sort(SortBenchmarkWrapper.GetWorkCopyOfArray());
			Console.WriteLine(string.Join(",", res));
			Console.WriteLine(s.OperationCount);

			s = new Insertion();
			res = s.Sort(SortBenchmarkWrapper.GetWorkCopyOfArray());
			Console.WriteLine();
			Console.WriteLine(string.Join(",", res));

			s = new Dwarf();
			res = s.Sort(SortBenchmarkWrapper.GetWorkCopyOfArray());
			Console.WriteLine();
			Console.WriteLine(string.Join(",", res));

			s = new Merge();
			res = s.Sort(SortBenchmarkWrapper.GetWorkCopyOfArray());
			Console.WriteLine();
			Console.WriteLine(string.Join(",", res));

			Console.ReadLine();
			BenchmarkRunner.Run<SortBenchmarkWrapper>();
			Console.ReadLine();
		}
	}
}