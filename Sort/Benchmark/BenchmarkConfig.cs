using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace Sort.Benchmark
{
	/// <summary>
	/// Конфигуратор замера скорости
	/// </summary>
	public class BenchmarkConfig : ManualConfig
	{
		public BenchmarkConfig()
		{
			this.Add(new Job { IterationTime = 1, WarmupCount = 1, TargetCount = 1 });
		}
	}
}