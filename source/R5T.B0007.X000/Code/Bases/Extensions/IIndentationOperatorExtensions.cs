using System;
using System.Collections.Generic;

using Microsoft.CodeAnalysis;

using R5T.B0007;
using R5T.L0011.F002;

using IndentationDocumentation = R5T.Y0003.Documentation.ForIndentation;
using Glossary = R5T.Y0003.Glossary;


namespace System
{
    public static class IIndentationOperatorExtensions
    {
        /// <summary>
        /// Converts from <inheritdoc cref="Glossary.ForIndentation.Indentation" path="/name"/> to <inheritdoc cref="Glossary.ForIndentation.LineIndentation" path="/name"/>.
        /// <para><inheritdoc cref="IndentationDocumentation.ConversionToIndentationFromLineIndentation" path="/summary"/></para>
        /// </summary>
        public static SyntaxTriviaList FromLineIndentation(this IIndentationOperator _,
            SyntaxTriviaList lineIndentation)
        {
            var output = IndentationHelper.FromLineIndentation(lineIndentation);
            return output;
        }

        public static IEnumerable<SyntaxTrivia> GetTabs_Enumerable(this IIndentationOperator _,
            int tabCount)
        {
            return IndentationHelper.GetTabs_Enumerable(tabCount);
        }

        public static SyntaxTriviaList GetTabs_SyntaxTriviaList(this IIndentationOperator _,
            int tabCount)
        {
            var output = IndentationHelper.GetTabs_SyntaxTriviaList(tabCount);
            return output;
        }

        /// <summary>
        /// Chooses <see cref="GetTabs_Enumerable(IIndentationOperator, int)"/> as the default.
        /// </summary>
        public static IEnumerable<SyntaxTrivia> GetTabs(this IIndentationOperator _,
            int tabCount)
        {
            return _.GetTabs_Enumerable(tabCount);
        }

        public static SyntaxTriviaList IndentByTab(this IIndentationOperator _,
            SyntaxTriviaList indentation)
        {
            var output = IndentationHelper.IndentByTab(indentation);
            return output;
        }

        /// <summary>
        /// Converts from <inheritdoc cref="Glossary.ForIndentation.Indentation" path="/name"/> to <inheritdoc cref="Glossary.ForIndentation.LineIndentation" path="/name"/>.
        /// <para><inheritdoc cref="IndentationDocumentation.ConversionToLineIndentationFromIndentation" path="/summary"/></para>
        /// </summary>
        public static SyntaxTriviaList ToLineIndentation(this IIndentationOperator _,
            SyntaxTriviaList indentation)
        {
            var output = IndentationHelper.ToLineIndentation(indentation);
            return output;
        }
    }
}
