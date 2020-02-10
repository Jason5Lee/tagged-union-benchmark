using System;
namespace Jason5Lee.TaggedUnionPatterns
{
    public static class ShapeExtension
    {
        public static double AreaMatch(this Shape shape) =>
            shape.Match(
#if (CASE2 || CASE3 || CASE4)
                c => Math.PI * c.Radius * c.Radius,
#endif
#if (CASE3 || CASE4)
                e => Math.Sqrt(3.0) / 4.0 * e.SideLen * e.SideLen,
#endif
#if CASE4
                s => s.SideLen * s.SideLen,
#endif
                r => r.Height * r.Width
            );
        public static double AreaMatchVoid(this Shape shape)
        {
            double area = 0.0;
            shape.Match(
#if (CASE2 || CASE3 || CASE4)
                c => { area = Math.PI * c.Radius * c.Radius; },
#endif
#if (CASE3 || CASE4)
                e => { area = Math.Sqrt(3.0) / 4.0 * e.SideLen * e.SideLen; },
#endif
#if CASE4
                s => { area = s.SideLen * s.SideLen; },
#endif
                r => { area = r.Height * r.Width; }
            );
            return area;
        }
        public static double AreaSwitch(this Shape shape)
        {
            switch(shape)
            {
#if (CASE2 || CASE3 || CASE4)
                case Circle c:
                    return Math.PI * c.Radius * c.Radius;
#endif
#if (CASE3 || CASE4)
                case EquilateralTriangle e:
                    return Math.Sqrt(3.0) / 4.0 * e.SideLen * e.SideLen;
#endif
#if CASE4
                case Square s:
                    return s.SideLen * s.SideLen;
#endif
                case Rectangle r:
                    return r.Height * r.Width;
                default:
                    throw new Exception($"Unknown shape: {shape.GetType()}.");
            }
        }
        public static double AreaVisit(this Shape shape) =>
            shape.Visit(
#if (CASE2 || CASE3 || CASE4)
                c => Math.PI * c.Radius * c.Radius,
#endif
#if (CASE3 || CASE4)
                e => Math.Sqrt(3.0) / 4.0 * e.SideLen * e.SideLen,
#endif
#if CASE4
                s => s.SideLen * s.SideLen,
#endif
                r => r.Height * r.Width
            );
        public static double AreaVisitVoid(this Shape shape)
        {
            double area = 0.0;
            shape.Visit(
#if (CASE2 || CASE3 || CASE4)
                c => { area = Math.PI * c.Radius * c.Radius; },
#endif
#if (CASE3 || CASE4)
                e => { area = Math.Sqrt(3.0) / 4.0 * e.SideLen * e.SideLen; },
#endif
#if CASE4
                s => { area = s.SideLen * s.SideLen; },
#endif
                r => { area = r.Height * r.Width; }
            );
            return area;
        }
    }
}
