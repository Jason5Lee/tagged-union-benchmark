namespace Jason5Lee.TaggedUnionPatterns.Benchmarks
{
    public interface IBenchmarkMission
    {
        void BenchmarkAreaSwitch();
        void BenchmarkAreaMatchVoid();
        void BenchmarkAreaMatch();
        void BenchmarkAreaVisitVoid();
        void BenchmarkAreaVisit();
        void BenchmarkAreaVirtual();
    }
}
