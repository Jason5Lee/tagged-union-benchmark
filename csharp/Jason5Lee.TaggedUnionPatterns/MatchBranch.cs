namespace Jason5Lee.TaggedUnionPatterns
{
    public delegate TResult OnCircle<out TResult>(double radius);

    public delegate TResult OnEquilateralTriangle<out TResult>(double sideLen);

    public delegate TResult OnSquare<out TResult>(double sideLen);

    public delegate TResult OnRectangle<out TResult>(double height, double width);
}