using System;
using System.Runtime.CompilerServices;

namespace Jason5Lee.TaggedUnionPatterns
{
    partial class Shape
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Match(
#if (CASE2 || CASE3 || CASE4)
            Action<Circle> circle, 
#endif
#if (CASE3 || CASE4)
            Action<EquilateralTriangle> equilateralTriangle,
#endif
#if CASE4
            Action<Square> square,
#endif
            Action<Rectangle> rectangle)
        {
            switch (this)
            {
#if (CASE2 || CASE3 || CASE4)
                case Circle c:
                    circle(c); break;
#endif
#if (CASE3 || CASE4)
                case EquilateralTriangle e:
                    equilateralTriangle(e); break;
#endif
#if CASE4
                case Square s:
                    square(s); break;
#endif
                case Rectangle r:
                    rectangle(r); break;
                default:
                    throw new Exception($"Unknown shape: {GetType()}.");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TResult Match<TResult>(
#if (CASE2 || CASE3 || CASE4)
            Func<Circle, TResult> circle,
#endif 
#if (CASE3 || CASE4)
            Func<EquilateralTriangle, TResult> equilateralTriangle,
#endif
#if CASE4
            Func<Square, TResult> square,
#endif
            Func<Rectangle, TResult> rectangle)
        {
            switch (this)
            {
#if (CASE2 || CASE3 || CASE4)
                case Circle c:
                    return circle(c);
#endif
#if (CASE3 || CASE4)
                case EquilateralTriangle e:
                    return equilateralTriangle(e);
#endif
#if CASE4
                case Square s:
                    return square(s);
#endif
                case Rectangle r:
                    return rectangle(r);
                default:
                    throw new Exception($"Unknown shape: {GetType()}.");
            }
        }
    }
}
