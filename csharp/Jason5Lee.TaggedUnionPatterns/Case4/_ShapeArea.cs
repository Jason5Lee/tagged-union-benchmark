using System;
namespace Jason5Lee.TaggedUnionPatterns.Case4
{
    partial class Shape
    {
        public abstract double AreaVirtual();
    }
    partial class Circle
    {
        public override double AreaVirtual() =>
            Math.PI * Radius * Radius;
    }

    partial class EquilateralTriangle
    {
        public override double AreaVirtual() =>
            Math.Sqrt(3.0) / 4.0 * SideLen * SideLen;
    }
    partial class Square
    {
        public override double AreaVirtual() =>
            SideLen * SideLen;
    }
    partial class Rectangle
    {
        public override double AreaVirtual() =>
            Height * Width;
    }
}
