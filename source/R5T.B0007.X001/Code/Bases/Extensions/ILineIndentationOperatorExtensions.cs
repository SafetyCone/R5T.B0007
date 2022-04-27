using System;

using R5T.T0130;

using ILineIndentationOperator = R5T.B0007.ILineIndentationOperator;
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
        public static LineIndentation FromIndentation(this ILineIndentationOperator _,
            Indentation indentation)
        {
            var output = _.FromIndentation(indentation.Value)
                .ToLineIndentation();

            return output;
        }

        public static LineIndentation IndentByTab(this ILineIndentationOperator _,
            Indentation indentation)
        {
            var output = _.IndentByTab(indentation.Value)
                .ToLineIndentation();

            return output;
        }

        /// <summary>
        /// Converts from <inheritdoc cref="Glossary.ForIndentation.LineIndentation" path="/name"/> to <inheritdoc cref="Glossary.ForIndentation.Indentation" path="/name"/>.
        /// <para><inheritdoc cref="IndentationDocumentation.ConversionToIndentationFromLineIndentation" path="/summary"/></para>
        /// </summary>
        public static Indentation ToIndentation(this ILineIndentationOperator _,
            LineIndentation lineIndentation)
        {
            var output = _.ToIndentation(lineIndentation.Value)
                .ToIndentation();

            return output;
        }
    }
}