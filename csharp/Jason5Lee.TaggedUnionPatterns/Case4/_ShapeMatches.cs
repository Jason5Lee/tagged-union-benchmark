using System;
using System.Runtime.CompilerServices;

namespace Jason5Lee.TaggedUnionPatterns.Case4
{
    partial class Shape
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Match(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Square> square,
            Action<Rectangle> rectangle)
        {
            switch (this)
            {
                case Circle c:
                    circle(c); break;
                case EquilateralTriangle e:
                    equilateralTriangle(e); break;
                case Square s:
                    square(s); break;
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
            Func<Square, TResult> square,
            Func<Rectangle, TResult> rectangle)
        {
            switch (this)
            {
                case Circle c:
                    return circle(c);
                case EquilateralTriangle e:
                    return equilateralTriangle(e);
                case Square s:
                    return square(s);
                case Rectangle r:
                    return rectangle(r);
                default:
                    throw new Exception($"Unknown shape: {GetType()}.");
            }
        }
    }
}
