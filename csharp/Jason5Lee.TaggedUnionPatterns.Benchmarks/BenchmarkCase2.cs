using Jason5Lee.TaggedUnionPatterns.Case2;
using System;

namespace Jason5Lee.TaggedUnionPatterns.Benchmarks
{
    public class BenchmarkCase2 : IBenchmarkMission
    {
        private readonly Shape[] shapes;
        private readonly TagShape[] tagShapes;
        
        public BenchmarkCase2()
        {
            var random = new Random();
            shapes = new Shape[Utils.N];
            tagShapes = new TagShape[Utils.N];
            for (int i = 0; i < shapes.Length; ++i)
            {
                switch (random.Next(2))
                {
                    case 0:
                        shapes[i] = new Circle(random.NextDouble());
                        break;
                    case 1:
                        shapes[i] = new Rectangle(random.NextDouble(), random.NextDouble());
                        break;
                }

                tagShapes[i] = shapes[i].ToTagShape();
            }
        }
        public void BenchmarkAreaSwitch()
        {
            foreach (var s in shapes)
            {
                Utils.Area = s.AreaSwitch();
            }
        }
        public void BenchmarkAreaMatchVoid()
        {
            foreach (var s in shapes)
            {
                Utils.Area = s.AreaMatchVoid();
            }
        }
        public void BenchmarkAreaMatch()
        {
            foreach (var s in shapes)
            {
                Utils.Area = s.AreaMatch();
            }
        }
        
        public void BenchmarkAreaVisitVoid()
        {
            foreach (var s in shapes)
            {
                Utils.Area = s.AreaVisitVoid();
            }
        }
        public void BenchmarkAreaVisit()
        {
            foreach (var s in shapes)
            {
                Utils.Area = s.AreaVisit();
            }
        }
        public void BenchmarkAreaVirtual()
        {
            foreach (var s in shapes)
            {
                Utils.Area = s.AreaVirtual();
            }
        }

        public void BenchmarkTagAreaSwitch()
        {
            foreach (var s in tagShapes)
            {
                Utils.Area = s.AreaSwitch();
            }
        }

        public void BenchmarkTagAreaMatch()
        {
            foreach (var s in tagShapes)
            {
                Utils.Area = s.AreaMatch();
            }
        }
    }
}
