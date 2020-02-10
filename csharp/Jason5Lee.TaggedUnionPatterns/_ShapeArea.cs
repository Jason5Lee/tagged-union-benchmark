using System;
namespace Jason5Lee.TaggedUnionPatterns
{
    partial class Shape
    {
        public abstract double AreaVirtual();
    }
#if (CASE2 || CASE3 || CASE4)
    partial class Circle
    {
        public override double AreaVirtual() =>
            Math.PI * Radius * Radius;
    }
#endif
#if (CASE3 || CASE4)
    partial class EquilateralTriangle
    {
        public override double AreaVirtual() =>
            Math.Sqrt(3.0) / 4.0 * SideLen * SideLen;
    }
#endif
#if CASE4
    partial class Square
    {
        public override double AreaVirtual() =>
            SideLen * SideLen;
    }
#endif
    partial class Rectangle
    {
        public override double AreaVirtual() =>
            Height * Width;
    }
}
