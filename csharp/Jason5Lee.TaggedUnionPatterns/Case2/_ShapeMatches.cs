using System;
using System.Runtime.CompilerServices;

namespace Jason5Lee.TaggedUnionPatterns.Case2
{
    partial class Shape
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Match(
            Action<Circle> circle, 
            Action<Rectangle> rectangle)
        {
            switch (this)
            {
                case Circle c:
                    circle(c); break;
                case Rectangle r:
                    rectangle(r); break;
                default:
                    throw new Exception($"Unknown shape: {GetType()}.");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TResult Match<TResult>(
            Func<Circle, TResult> circle,
            Func<Rectangle, TResult> rectangle)
        {
            switch (this)
            {
                case Circle c:
                    return circle(c);
                case Rectangle r:
                    return rectangle(r);
                default:
                    throw new Exception($"Unknown shape: {GetType()}.");
            }
        }
    }
}
