using System;

namespace Jason5Lee.TaggedUnionPatterns
{
    partial class Shape
    {
        public abstract void Visit(
#if (CASE2 || CASE3 || CASE4)
            Action<Circle> circle, 
#endif
#if (CASE3 || CASE4)
            Action<EquilateralTriangle> equilateralTriangle,
#endif
#if CASE4
            Action<Square> square,
#endif
            Action<Rectangle> rectangle);
        public abstract TResult Visit<TResult>(
#if (CASE2 || CASE3 || CASE4)
            Func<Circle, TResult> circle, 
#endif
#if (CASE3 || CASE4)
            Func<EquilateralTriangle, TResult> equilateralTriangle,
#endif
#if CASE4
            Func<Square, TResult> square,
#endif
            Func<Rectangle, TResult> rectangle);
        
    }
#if (CASE2 || CASE3 || CASE4)
    partial class Circle
    {
        public override void Visit(
            Action<Circle> circle, 
#if (CASE3 || CASE4)
            Action<EquilateralTriangle> equilateralTriangle,
#endif
#if CASE4
            Action<Square> square,
#endif
            Action<Rectangle> rectangle)
        => circle(this);

        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
#if (CASE3 || CASE4)
            Func<EquilateralTriangle, TResult> equilateralTriangle,
#endif
#if CASE4
            Func<Square, TResult> square,
#endif
            Func<Rectangle, TResult> rectangle)
        => circle(this);
    }
#endif

#if (CASE3 || CASE4)
    partial class EquilateralTriangle
    {
        public override void Visit(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
#if CASE4
            Action<Square> square,
#endif
            Action<Rectangle> rectangle)
        => equilateralTriangle(this);
        
        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<EquilateralTriangle, TResult> equilateralTriangle,
#if CASE4
            Func<Square, TResult> square,
#endif
            Func<Rectangle, TResult> rectangle)
        => equilateralTriangle(this);
    }
#endif

#if CASE4
    partial class Square
    {
        public override void Visit(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Square> square,
            Action<Rectangle> rectangle)
        => square(this);
        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<EquilateralTriangle, TResult> equilateralTriangle,
            Func<Square, TResult> square,
            Func<Rectangle, TResult> rectangle)
        => square(this);
    }
#endif

    partial class Rectangle
    {
        public override void Visit(
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
        => rectangle(this);

        public override TResult Visit<TResult>(
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
        => rectangle(this);
    }
}
