using System;

using R5T.T0130;

using ILineIndentation = R5T.B0007.ILineIndentation;

using Instances = R5T.B0007.X003.Instances;


namespace System
{
    public static class ILineIndentationExtensions
    {
        public static LineIndentation ByTabCount(this ILineIndentation _,
            int tabCount)
        {
            var output = Instances.LineIndentationOperator.FromIndentation(
                Instances.Indentation.ByTabCount(tabCount));

            return output;
        }

        public static LineIndentation NewLine(this ILineIndentation _)
        {
            var output = _.NewLine_SyntaxTriviaList()
                .ToLineIndentation();

            return output;
        }

        public static LineIndentation BlankLine(this ILineIndentation _)
        {
            var output = _.BlankLine_SyntaxTriviaList()
                .ToLineIndentation();

            return output;
        }

        public static LineIndentation TwoBlankLines(this ILineIndentation _)
        {
            var output = _.TwoBlankLines_SyntaxTriviaList()
                .ToLineIndentation();

            return output;
        }
    }
}