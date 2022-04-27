using System;

using Microsoft.CodeAnalysis;

using R5T.B0007;
using R5T.L0011.F002;

using IndentationDocumentation = R5T.Y0003.Documentation.ForIndentation;
using Glossary = R5T.Y0003.Glossary;


namespace System
{
    public static class ILineIndentationOperatorExtensions
    {
        /// <summary>
        /// Converts from <inheritdoc cref="Glossary.ForIndentation.Indentation" path="/name"/> to <inheritdoc cref="Glossary.ForIndentation.LineIndentation" path="/name"/>.
        /// <para><inheritdoc cref="IndentationDocumentation.ConversionToLineIndentationFromIndentation" path="/summary"/></para>
        /// </summary>
        public static SyntaxTriviaList FromIndentation(this ILineIndentationOperator _,
            SyntaxTriviaList indentation)
        {
            var output = LineIndentationHelper.FromIndentation(indentation);
            return output;
        }

        public static SyntaxTriviaList IndentByTab(this ILineIndentationOperator _,
            SyntaxTriviaList indentation)
        {
            var output = LineIndentationHelper.IndentByTab(indentation);
            return output;
        }

        /// <summary>
        /// Converts from <inheritdoc cref="Glossary.ForIndentation.LineIndentation" path="/name"/> to <inheritdoc cref="Glossary.ForIndentation.Indentation" path="/name"/>.
        /// <para><inheritdoc cref="IndentationDocumentation.ConversionToIndentationFromLineIndentation" path="/summary"/></para>
        /// </summary>
        public static SyntaxTriviaList ToIndentation(this ILineIndentationOperator _,
            SyntaxTriviaList lineIndentation)
        {
            var output = LineIndentationHelper.ToIndentation(lineIndentation);
            return output;
        }
    }
}