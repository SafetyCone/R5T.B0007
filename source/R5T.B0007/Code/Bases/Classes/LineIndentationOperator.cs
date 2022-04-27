using System;


namespace R5T.B0007
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class LineIndentationOperator : ILineIndentationOperator
    {
        #region Static
        
        public static LineIndentationOperator Instance { get; } = new();

        #endregion
    }
}