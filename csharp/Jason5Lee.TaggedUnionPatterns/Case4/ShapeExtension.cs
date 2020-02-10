using System;
namespace Jason5Lee.TaggedUnionPatterns.Case4
{
    public static class ShapeExtension
    {
        public static double AreaMatch(this Shape shape) =>
            shape.Match(
                c => Math.PI * c.Radius * c.Radius,
                e => Math.Sqrt(3.0) / 4.0 * e.SideLen * e.SideLen,
                s => s.SideLen * s.SideLen,
                r => r.Height * r.Width
            );
        public static double AreaMatchVoid(this Shape shape)
        {
            double area = 0.0;
            shape.Match(
                c => { area = Math.PI * c.Radius * c.Radius; },
                e => { area = Math.Sqrt(3.0) / 4.0 * e.SideLen * e.SideLen; },
                s => { area = s.SideLen * s.SideLen; },
                r => { area = r.Height * r.Width; }
            );
            return area;
        }
        public static double AreaSwitch(this Shape shape)
        {
            switch(shape)
            {
                case Circle c:
                    return Math.PI * c.Radius * c.Radius;
                case EquilateralTriangle e:
                    return Math.Sqrt(3.0) / 4.0 * e.SideLen * e.SideLen;
                case Square s:
                    return s.SideLen * s.SideLen;
                case Rectangle r:
                    return r.Height * r.Width;
                default:
                    throw new Exception($"Unknown shape: {shape.GetType()}.");
            }
        }
        public static double AreaVisit(this Shape shape) =>
            shape.Visit(
                c => Math.PI * c.Radius * c.Radius,
                e => Math.Sqrt(3.0) / 4.0 * e.SideLen * e.SideLen,
                s => s.SideLen * s.SideLen,
                r => r.Height * r.Width
            );
        public static double AreaVisitVoid(this Shape shape)
        {
            double area = 0.0;
            shape.Visit(
                c => { area = Math.PI * c.Radius * c.Radius; },
                e => { area = Math.Sqrt(3.0) / 4.0 * e.SideLen * e.SideLen; },
                s => { area = s.SideLen * s.SideLen; },
                r => { area = r.Height * r.Width; }
            );
            return area;
        }
    }
}
