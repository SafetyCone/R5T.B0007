using System;


namespace R5T.B0007
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class IndentationOperator : IIndentationOperator
    {
        #region Static
        
        public static IndentationOperator Instance { get; } = new();

        #endregion
    }
}