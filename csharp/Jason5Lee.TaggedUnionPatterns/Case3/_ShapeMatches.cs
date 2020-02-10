using System;
using System.Runtime.CompilerServices;

namespace Jason5Lee.TaggedUnionPatterns.Case3
{
    partial class Shape
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Match(
            Action<Circle> circle,
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Rectangle> rectangle)
        {
            switch (this)
            {
                case Circle c:
                    circle(c); break;
                case EquilateralTriangle e:
                    equilateralTriangle(e); break;
                case Rectangle r:
                    rectangle(r); break;
                default:
                    throw new Exception($"Unknown shape: {GetType()}.");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TResult Match<TResult>(
            Func<Circle, TResult> circle,
            Func<EquilateralTriangle, TResult> equilateralTriangle,
            Func<Rectangle, TResult> rectangle)
        {
            switch (this)
            {
                case Circle c:
                    return circle(c);
                case EquilateralTriangle e:
                    return equilateralTriangle(e);
                case Rectangle r:
                    return rectangle(r);
                default:
                    throw new Exception($"Unknown shape: {GetType()}.");
            }
        }
    }
}
