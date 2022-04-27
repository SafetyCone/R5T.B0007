using System;

using R5T.L0011.Z002;
using R5T.T0130;

using IIndentation = R5T.B0007.IIndentation;


namespace System
{
    public static class IIndentationExtensions
    {
        public static Indentation ByTabCount(this IIndentation _,
            int tabCount)
        {
            var output = _.ByTabCount_SyntaxTriviaList(tabCount)
                .ToIndentation();

            return output;
        }

        public static Indentation Class(this IIndentation _)
        {
            var output = _.ByTabCount(
                TabCounts.ClassTabCount);

            return output;
        }
    }
}
