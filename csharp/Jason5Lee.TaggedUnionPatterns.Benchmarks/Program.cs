using BenchmarkDotNet.Running;

namespace Jason5Lee.TaggedUnionPatterns.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BenchmarkArea>();
        }
    }
}
