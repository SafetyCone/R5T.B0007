using System;

using R5T.T0130;

using IIndentationOperator = R5T.B0007.IIndentationOperator;
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
        public static Indentation FromLineIndentation(this IIndentationOperator _,
            LineIndentation lineIndentation)
        {
            var output = _.FromLineIndentation(lineIndentation.Value)
                .ToIndentation();

            return output;
        }

        public static Indentation GetTabs_Indentation(this IIndentationOperator _,
            int tabCount)
        {
            var output = _.GetTabs_SyntaxTriviaList(tabCount)
                .ToIndentation();

            return output;
        }

        public static Indentation IndentByTab(this IIndentationOperator _,
            Indentation indentation)
        {
            var output = _.IndentByTab(indentation.Value)
                .ToIndentation();

            return output;
        }

        /// <summary>
        /// Converts from <inheritdoc cref="Glossary.ForIndentation.Indentation" path="/name"/> to <inheritdoc cref="Glossary.ForIndentation.LineIndentation" path="/name"/>.
        /// <para><inheritdoc cref="IndentationDocumentation.ConversionToLineIndentationFromIndentation" path="/summary"/></para>
        /// </summary>
        public static LineIndentation ToLineIndentation(this IIndentationOperator _,
            Indentation indentation)
        {
            var output = _.ToLineIndentation(indentation.Value)
                .ToLineIndentation();

            return output;
        }
    }
}
