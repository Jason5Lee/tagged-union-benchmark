using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Jason5Lee.TaggedUnionPatterns.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(RuntimeMoniker.CoreRt31)]
    [RankColumn]
    // [RPlotExporter]
    public class BenchmarkArea
    {
        [Params(2, 3, 4)]
        public int nCases;

        private IBenchmarkMission mission;
        
        [GlobalSetup]
        public void Setup()
        {
            switch(nCases)
            {
                case 2:
                    mission = new BenchmarkCase2();
                    break;
                case 3:
                    mission = new BenchmarkCase3();
                    break;
                case 4:
                    mission = new BenchmarkCase4();
                    break;
            }
        }

        [Benchmark]
        public void AreaSwitch() => mission.BenchmarkAreaSwitch();

        [Benchmark]
        public void AreaMatchVoid() => mission.BenchmarkAreaMatchVoid();

        [Benchmark]
        public void AreaMatch() => mission.BenchmarkAreaMatch();
        
        [Benchmark]
        public void AreaVisitVoid() => mission.BenchmarkAreaVisitVoid();

        [Benchmark]
        public void AreaVisit() => mission.BenchmarkAreaVisit();

        [Benchmark]
        public void AreaVirtual() => mission.BenchmarkAreaVirtual();

        [Benchmark]
        public void TagAreaSwitch() => mission.BenchmarkTagAreaSwitch();

        [Benchmark]
        public void TagAreaMatch() => mission.BenchmarkTagAreaMatch();
    }
}
