namespace Jason5Lee.TaggedUnionPatterns
{
    partial class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    partial class EquilateralTriangle
    {
        public EquilateralTriangle(double sideLen)
        {
            SideLen = sideLen;
        }
    }
    partial class Square
    {
        public Square(double sideLen)
        {
            SideLen = sideLen;
        }
    }
    partial class Rectangle
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }
}
