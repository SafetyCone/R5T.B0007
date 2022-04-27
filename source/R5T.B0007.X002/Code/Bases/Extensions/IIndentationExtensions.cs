using System;

using Microsoft.CodeAnalysis;

using R5T.B0007;
using R5T.L0011.F002;


namespace System
{
    public static class IIndentationExtensions
    {
        public static SyntaxTriviaList IncreaseByTab_SyntaxTriviaList(this IIndentation _,
            SyntaxTriviaList indentation)
        {
            var output = _.IncreaseByTabCount_SyntaxTriviaList(
                indentation,
                // Increase by 1 (one) tab.
                1);

            return output;
        }

        public static SyntaxTriviaList IncreaseByTabCount_SyntaxTriviaList(this IIndentation _,
            SyntaxTriviaList indentation,
            int tabCount)
        {
            var extraIndentation = _.ByTabCount_SyntaxTriviaList(tabCount);

            var output = indentation.Append(extraIndentation);
            return output;
        }

        public static SyntaxTriviaList ByTabCount_SyntaxTriviaList(this IIndentation _,
            int tabCount)
        {
            var output = IndentationHelper.GetTabs_SyntaxTriviaList(tabCount);
            return output;
        }
    }
}
