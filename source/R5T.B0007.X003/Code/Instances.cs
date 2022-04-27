using System;


namespace R5T.B0007.X003
{
    public static class Instances
    {
        public static IIndentation Indentation { get; } = B0007.Indentation.Instance;
        public static ILineIndentationOperator LineIndentationOperator { get; } = B0007.LineIndentationOperator.Instance;
    }
}
