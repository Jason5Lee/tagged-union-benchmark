namespace Jason5Lee.TaggedUnionPatterns
{
#if (CASE2 || CASE3 || CASE4)
    partial class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
#endif
#if (CASE3 || CASE4)
    partial class EquilateralTriangle
    {
        public EquilateralTriangle(double sideLen)
        {
            SideLen = sideLen;
        }
    }
#endif
#if CASE4
    partial class Square
    {
        public Square(double sideLen)
        {
            SideLen = sideLen;
        }
    }
#endif
    partial class Rectangle
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }
}
